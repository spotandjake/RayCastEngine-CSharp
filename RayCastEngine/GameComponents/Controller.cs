using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace RayCastEngine.GameComponents {
  abstract class Controller {
    // Properties
    public Vector3 Position;
    public Vector3 Direction;
    // Todo: Tempory Value Until we figure out how to calculate plane based off fov
    public Vector2 Plane; // planeX, planeY
    public Sprite Parent;
    // Constructor
    public virtual void Initialize(Vector3 position, Vector3 direction, Sprite parent) {
      Position = position;
      Direction = direction;
      Plane = new Vector2(0f, 0.66f);
      Parent = parent;
    }
    // Methods
    public abstract WorldUpdateResult Update(TimeSpan gameTime, World world, float health);
  }
  // Static Controllers
  class BarrrelController : Controller {
    // Properties
    private Sprite lootItem;
    // Constructor
    public BarrrelController(Sprite lootItem = null) {
      // Choose Loot Item
      this.lootItem = lootItem;
    }
    public override void Initialize(Vector3 position, Vector3 direction, Sprite parent) {
      Position = position;
      Direction = direction;
      Plane = new Vector2(0f, 0.66f);
      Parent = parent;
      // Set Loot
      if (this.lootItem == null) {
        // TODO: Choose The Item At Random
        this.lootItem = new Sprite(this.Position, this.Direction, Texture.HeartPowerUp, true, new PowerUpController(PowerUp.MaxHealth));
      }
      // Set barrel Health
      this.Parent.setMaxHealth(10f);
    }
    // Methods
    public override WorldUpdateResult Update(TimeSpan gameTime, World world, float health) {
      // Spawn In A new Sprite
      if (health <= 0) {
        // Add The Loot
        world.SpritePool.Add(this.lootItem);
      }
      // Return The Current State
      return new WorldUpdateResult {
        SceneUpdate = false,
        SpriteUpdate = true,
        UiUpdate = true,
        removeSelf = health <= 0,
      };
    }
  }
  class PowerUpController : Controller {
    // Properties
    private PowerUp powerUp;
    // Constructor
    public PowerUpController(PowerUp powerUp) {
      // Choose Loot Item
      this.powerUp = powerUp;
    }
    // Methods
    public override WorldUpdateResult Update(TimeSpan gameTime, World world, float health) {
      // If The player Is Within Range Give Them The PowerUp And Die
      Sprite closestSprite = null;
      float closestDistance = 0;
      for (int spriteIndex = 0; spriteIndex < world.SpritePool.Count; spriteIndex++) {
        Sprite currentSprite = world.SpritePool[spriteIndex];
        if (!(currentSprite.Controller is LocalPlayerController)) continue;
        // Calculate Distance
        float spriteDistance = (float)Math.Sqrt(
          (Position.X - currentSprite.Position.X) *
          (Position.X - currentSprite.Position.X) +
          (Position.Y - currentSprite.Position.Y) *
          (Position.Y - currentSprite.Position.Y) +
          (Position.Z - currentSprite.Position.Z) *
          (Position.Z - currentSprite.Position.Z)
        );
        // Check Distance
        if (closestDistance == 0 || closestDistance > spriteDistance) {
          closestDistance = spriteDistance;
          closestSprite = currentSprite;
        }
      }
      // If Close Enough Hit
      if (closestSprite != null && closestDistance <= 1f) {
        switch (this.powerUp) {
          case PowerUp.MaxHealth:
            closestSprite.setMaxHealth(closestSprite.maxHealth + 10);
            // Return The Current State
            return new WorldUpdateResult {
              SceneUpdate = false,
              SpriteUpdate = true,
              UiUpdate = true,
              removeSelf = true,
            };
          // TODO: Handle An Ammo Powerup
        }
      }
      // Return The Current State
      return new WorldUpdateResult {
        SceneUpdate = false,
        SpriteUpdate = true,
        UiUpdate = true,
        removeSelf = health <= 0,
      };
    }
  }
  // Networked Controller
  // Local Controller
  class LocalPlayerController : Controller {
    // Properties
    private Vector3 Velocity;
    private bool Crouch = false;
    private bool Running = false;
    private bool CrouchButtonPressed = false;
    private Network net;
    private Weapon currentWeapon = new Weapon(WeaponType.Pistol, 10f, false);
    private float LastFired = 0;
    // Constructor
    public LocalPlayerController(Network net) {
      this.net = net;
    }
    // Methods
    public override WorldUpdateResult Update(TimeSpan gameTime, World world, float health) {
      // Handle Death
      if (this.Parent.health < this.Parent.maxHealth && this.Parent.lastHit > 240) {
        this.Parent.health++;
      }
      if (this.Parent.health <= 0) {
        Console.WriteLine("Dead");
        //return new WorldUpdateResult {
        //  SceneUpdate = false,
        //  SpriteUpdate = false,
        //  UiUpdate = false,
        //  removeSelf = false,
        //};
      }
      // Handle Keys And Stuff
      KeyboardState keys = Keyboard.GetState();
      MouseState mouse = Mouse.GetState();
      GamePadState gamepad = GamePad.GetState(0);
      float forwardAxis = 0;
      float sideAxis = 0;
      float yawAxis = 0;
      float pitchAxis = 0;
      bool Jump = false;
      bool shooting = false;
      // We want to normalize movement over time so you move the same distance no matter the fps
      float frameTime = gameTime.Milliseconds / 1000.0f;
      // Normalized Move Speeds
      #region Convert Input Axis
      if (gamepad.IsConnected) {
        // Movement
        forwardAxis = gamepad.ThumbSticks.Left.Y;
        sideAxis = gamepad.ThumbSticks.Left.X;
        // Looking
        pitchAxis = gamepad.ThumbSticks.Right.Y;
        yawAxis = gamepad.ThumbSticks.Right.X;
        // Modifiers
        if (gamepad.Buttons.A == ButtonState.Pressed) {
          Crouch = false;
          CrouchButtonPressed = false;
          Jump = true;
        }
        if (gamepad.Buttons.RightStick == ButtonState.Pressed && CrouchButtonPressed == false) {
          CrouchButtonPressed = true;
          Crouch = !Crouch;
        } else if (gamepad.Buttons.RightStick == ButtonState.Released) CrouchButtonPressed = false;
        // Stop Running
        if (forwardAxis == 0 && sideAxis == 0) Running = false;
        if (gamepad.Buttons.LeftStick == ButtonState.Pressed) Running = true;
        if (gamepad.Triggers.Left > 0.5f || gamepad.Triggers.Right > 0.5f) shooting = true;
      } else {
        // WASD
        if (keys.IsKeyDown(Keys.W)) forwardAxis += 1;
        if (keys.IsKeyDown(Keys.S)) forwardAxis -= 1;
        if (keys.IsKeyDown(Keys.D)) sideAxis += 1;
        if (keys.IsKeyDown(Keys.A)) sideAxis -= 1;
        // Arrow Keys
        if (keys.IsKeyDown(Keys.Right)) yawAxis += 1;
        if (keys.IsKeyDown(Keys.Left)) yawAxis -= 1;
        if (keys.IsKeyDown(Keys.Up)) pitchAxis += 1;
        if (keys.IsKeyDown(Keys.Down)) pitchAxis -= 1;
        // Modifiers
        if (keys.IsKeyDown(Keys.Space)) Jump = true;
        if (keys.IsKeyDown(Keys.LeftControl)) Crouch = true;
        else if (keys.IsKeyUp(Keys.LeftControl)) Crouch = false;
        if (keys.IsKeyDown(Keys.LeftShift)) Running = true;
        // Shooting
        if (mouse.LeftButton == ButtonState.Pressed) shooting = true;
      }
      #endregion
      Vector3 AdditionalVelocity = Vector3.Zero;
      float rotSpeed = frameTime * 2f; //the constant value is in radians/second
      #region Movement
      if (Position.Z < 0.25f && Position.Z > -0.25f)
        Position.Z = 0;
      else if (Position.Z > 0)
        Velocity.Z = Position.Z * -2f;
      else if (Position.Z < 0)
        Velocity.Z = Position.Z * -2f;
      // Strafe Right
      // Forward
      AdditionalVelocity.X += (forwardAxis * Direction.X + sideAxis * Direction.Y);
      AdditionalVelocity.Y += (forwardAxis * Direction.Y + sideAxis * -Direction.X);
      #endregion
      #region Rotation
      if (yawAxis != 0) {
        double cosRotSpeed = Math.Cos(rotSpeed * yawAxis);
        double sinRotSpeed = Math.Sin(rotSpeed * yawAxis);
        float olddirx = Direction.X, oldPlaneX = Plane.X;
        Direction.X = (float)(Direction.X * cosRotSpeed - Direction.Y * -sinRotSpeed);
        Direction.Y = (float)(olddirx * -sinRotSpeed + Direction.Y * cosRotSpeed);
        Plane.X = (float)(Plane.X * cosRotSpeed - Plane.Y * -sinRotSpeed);
        Plane.Y = (float)(oldPlaneX * -sinRotSpeed + Plane.Y * cosRotSpeed);
      }
      if (pitchAxis != 0) {
        Direction.Z += 400 * rotSpeed * (Direction.Z < 500 && Direction.Z > -500 ? pitchAxis : 0);
      } else {
        if (Direction.Z < 0.25f && Direction.Z > -0.25f)
          Direction.Z = 0;
        else if (Direction.Z > 0)
          Direction.Z /= 1.25f;
        else if (Direction.Z < 0)
          Direction.Z /= 1.25f;
      }
      #endregion
      #region Modifiers 
      // jump
      if (Jump && Position.Z == 0) {
        Velocity.Z += 200;
        this.Parent.lowerHealth(1f);
      }
      // crouch
      if (Crouch) Velocity.Z -= 200;
      #endregion
      WorldUpdateResult sceneState = new WorldUpdateResult {
        SceneUpdate = false,
        SpriteUpdate = false,
        UiUpdate = false,
        removeSelf = false,
      };
      #region ApplyMotion
      // Apply Dampening
      if (AdditionalVelocity.Length() > 0) AdditionalVelocity.Normalize();
      // Dappen Velocity
      float dampening = Position.Z == 0 ? 3f : 5f;
      if (AdditionalVelocity.X != 0) Velocity.X = AdditionalVelocity.X * (Running ? .4f : .2f) * (Crouch ? 0.5f : 1);
      else Velocity.X /= dampening;
      if (AdditionalVelocity.Y != 0) Velocity.Y = AdditionalVelocity.Y * (Running ? .4f : .2f) * (Crouch ? 0.5f : 1);
      else Velocity.Y /= dampening;
      if (AdditionalVelocity.Z != 0) Velocity.Z = AdditionalVelocity.Z;
      else Velocity.Z /= dampening;
      // Update State
      if (Velocity.X != 0 || Velocity.Y != 0 || Velocity.Z != 0 || yawAxis != 0 || pitchAxis != 0) {
        // Set Position
        float projectedX = Position.X + Velocity.X;
        float projectedY = Position.Y + Velocity.Y;
        if (world.getWall((int)projectedX, (int)Position.Y) == Texture.Air) Position.X = projectedX;
        if (world.getWall((int)Position.X, (int)projectedY) == Texture.Air) Position.Y = projectedY;
        Position.Z += Velocity.Z;
        // Send Update Data
        net.sendPositionPackage(Position, Direction);
        // Set Update
        sceneState.SceneUpdate = true;
        sceneState.SpriteUpdate = true;
        sceneState.UiUpdate = true;
      }
      #endregion
      #region shoot
      // Shooting
      if (shooting && currentWeapon != null && LastFired == 0) {
        // Spawn Bullet
        currentWeapon.spawnBullet(Position, Direction, world);
        // Set Update
        sceneState.SpriteUpdate = true;
        // Set CoolDown
        LastFired = currentWeapon.shootRate;
      }
      // Lower LastFired
      if (LastFired > 0) LastFired--;
      // Vibrate Contoller
      float vibrationAmmount = Math.Max(map(LastFired, currentWeapon.shootRate-7, currentWeapon.shootRate, 0, 1)*2, 0);
      GamePad.SetVibration(PlayerIndex.One, vibrationAmmount, vibrationAmmount);
      #endregion
      return sceneState;
    }
    // Helper
    private float map(float s, float a1, float a2, float b1, float b2) {
      return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
    }
  }
  // Bullet Controller
  class BulletController : Controller {
    // Properties
    // TODO: Set These From The Gun
    private float distance = 0f;
    private float speed = 0.25f;
    private float accuracy = 1f;
    private float damage = 10f;
    public bool hitPlayer;
    // Constructor
    public BulletController(float distance, bool hitPlayer) {
      this.distance = distance;
      this.hitPlayer = hitPlayer;
    }
    // Methods
    public override WorldUpdateResult Update(TimeSpan gameTime, World world, float health) {
      WorldUpdateResult currentState = new WorldUpdateResult {
        SceneUpdate = true,
        SpriteUpdate = true,
        UiUpdate = true,
        removeSelf = false,
      };
      // Move Forward
      Position.X += (speed * Direction.X);
      Position.Y += (speed * Direction.Y);
      // Check For Hit
      if (distance <= 0) currentState.removeSelf = true;
      if (currentState.SpriteUpdate) {
        if (world.getWall((int)Position.X, (int)Position.Y) != Texture.Air) currentState.removeSelf = true;
        if (world.getWall((int)Position.X, (int)Position.Y) != Texture.Air) currentState.removeSelf = true;
      }
      Sprite closestSprite = null;
      float closestDistance = 0;
      for (int spriteIndex = 0; spriteIndex < world.SpritePool.Count; spriteIndex++) {
        Sprite currentSprite = world.SpritePool[spriteIndex];
        if (this.hitPlayer) {
          if (!(currentSprite.Controller is LocalPlayerController)) continue;
        } else {
          if (
            currentSprite.Controller is LocalPlayerController ||
            currentSprite.Controller is BulletController ||
            currentSprite.Controller == null
          )
            continue;
        }
        // Calculate Distance
        float spriteDistance = (float)Math.Sqrt(
          (Position.X - currentSprite.Position.X) *
          (Position.X - currentSprite.Position.X) +
          (Position.Y - currentSprite.Position.Y) *
          (Position.Y - currentSprite.Position.Y) +
          (Position.Z - currentSprite.Position.Z) *
          (Position.Z - currentSprite.Position.Z)
        );
        // Check Distance
        if (closestDistance == 0 || closestDistance > spriteDistance) {
          closestDistance = spriteDistance;
          closestSprite = currentSprite;
        }
      }
      // If Close Enough Hit
      if (closestSprite != null && closestDistance <= this.accuracy) {
        closestSprite.lowerHealth(this.damage);
        currentState.removeSelf = true;
      }
      // Kill If has hit max range
      this.distance -= speed;
      // If No Update Return False
      return currentState;
    }
  }
  // Enemy Controller
  class EnemyController : Controller {
    // Properties
    private bool Boss;
    private Weapon currentWeapon = new Weapon(WeaponType.Pistol, 50f, true);
    private float LastFired = 0;
    // Constructor
    public EnemyController (bool boss) {
      Boss = boss;
    }
    // Methods
    public override WorldUpdateResult Update(TimeSpan gameTime, World world, float health) {
      WorldUpdateResult currentState = new WorldUpdateResult {
        SceneUpdate = false,
        SpriteUpdate = false,
        UiUpdate = false,
        removeSelf = health <= 0,
      };
      Vector3 newPosition = new Vector3();
      // Enemy Logic
      Sprite closestPlayer = null;
      float closestDistance = 0;
      for (int playerIndex = 0; playerIndex < world.SpritePool.Count; playerIndex++) {
        Sprite currentPlayer = world.SpritePool[playerIndex];
        if (!(currentPlayer.Controller is LocalPlayerController)) continue;
        // Calculate Distance
        float playerDistance = (float)Math.Sqrt(
          (Position.X - currentPlayer.Position.X) *
          (Position.X - currentPlayer.Position.X) +
          (Position.Y - currentPlayer.Position.Y) *
          (Position.Y - currentPlayer.Position.Y) +
          (Position.Z - currentPlayer.Position.Z) *
          (Position.Z - currentPlayer.Position.Z)
        );
        // Check Distance
        if (closestDistance == 0 || closestDistance > playerDistance) {
          closestDistance = playerDistance;
          closestPlayer = currentPlayer;
        }
      }
      // Choose A Random Decision
      if (closestDistance != 0 && closestDistance < 5) { // If close enough to attack
        // TODO: We want to follow close
        Vector3 playerDirection = Vector3.Normalize(
          Vector3.Subtract(
            Position,
            closestPlayer.Position
          )
        );
        newPosition = Vector3.Add(
          Position,
          Vector3.Multiply(
           playerDirection,
            -2f * gameTime.Milliseconds / 1000.0f
          )
        );
        // Turn towards Player
        Direction = Vector3.Multiply(playerDirection, -1f);
        // Shoot
        #region shoot
        // Shooting
        if (currentWeapon != null && LastFired == 0) {
          // Spawn Bullet
          currentWeapon.spawnBullet(Position, Direction, world);
          // Set Update
          currentState.SpriteUpdate = true;
          // Set CoolDown
          LastFired = currentWeapon.shootRate;
        }
        // Lower LastFired
        if (LastFired > 0) LastFired--;
        #endregion
        // TODO: Create A Random Decision Loop
        currentState.SpriteUpdate = true;
      } else if (closestDistance != 0 && closestDistance < 20) { // If close enough to move see player, we want to take the direction into consideration here eventaully
        // Move Towards Slower
        // TODO: Add Some Randomness To The Movement
        newPosition = Vector3.Add(
          Position,
          Vector3.Multiply(
            Vector3.Normalize(
              Vector3.Subtract(
                Position,
                closestPlayer.Position
              )
            ),
            -0.5f * gameTime.Milliseconds / 1000.0f
          )
        );
        currentState.SpriteUpdate = true;
      } else { // If Not Close To Player Patrol
        // TODO: Patrol
      }
      // If we have moved ensure we are not in the wall
      if (currentState.SpriteUpdate) {
        if (world.getWall((int)newPosition.X, (int)Position.Y) == Texture.Air) Position.X = newPosition.X;
        if (world.getWall((int)Position.X, (int)newPosition.Y) == Texture.Air) Position.Y = newPosition.Y;
      }
      // TODO: If We Are Not In View Of The Player No Update
      // If No Update Return False
      return currentState;
    }
  }
}