using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace RayCastEngine.GameComponents {
  abstract  class Controller {
    // Properties
    public Vector3 Position;
    public Vector3 Direction;
    // Todo: Tempory Value Until we figure out how to calculate plane based off fov
    public Vector2 Plane; // planeX, planeY
    // Constructor
    public void Initialize(Vector3 position, Vector3 direction) {
      Position = position;
      Direction = direction;
      Plane = new Vector2(0f, 0.66f);
    }
    // Methods
    public abstract bool Update(TimeSpan gameTime, World world);
  }
  // Networked Controller
  // Local Controller
  class LocalPlayerController : Controller {
    // Properties
    private Vector3 Velocity;
    // Constructor
    // Methods
    public override bool Update(TimeSpan gameTime, World world) {
      KeyboardState keys = Keyboard.GetState();
      float forwardAxis = 0;
      float sideAxis = 0;
      float yawAxis = 0;
      float pitchAxis = 0;
      // We want to normalize movement over time so you move the same distance no matter the fps
      float frameTime = gameTime.Milliseconds / 1000.0f;
      // Normalized Move Speeds
      float moveSpeed = frameTime * 3f; //the constant value is in squares/second
      float rotSpeed = frameTime * 2f; //the constant value is in radians/second
      #region Convert Input Axis
      // WASD
      if (keys.IsKeyDown(Keys.W)) forwardAxis += 1;
      if (keys.IsKeyDown(Keys.S)) forwardAxis -= 1;
      if (keys.IsKeyDown(Keys.D)) sideAxis += 1;
      if (keys.IsKeyDown(Keys.A)) sideAxis -= 1;
      // Arrow Keys
      if (keys.IsKeyDown(Keys.Right)) yawAxis += 1;
      if (keys.IsKeyDown(Keys.Left)) yawAxis -= 1;
      if (keys.IsKeyDown(Keys.Down)) pitchAxis += 1;
      if (keys.IsKeyDown(Keys.Up)) pitchAxis -= 1;
      #endregion
      Vector3 AdditionalVelocity = Vector3.Zero;
      #region Movement
      // Forward
      AdditionalVelocity.X += Direction.X * moveSpeed * forwardAxis;
      AdditionalVelocity.Y += Direction.Y * moveSpeed * forwardAxis;
      // Strafe Right
      // TODO: if we set Math.Atan2 to 0 then we should get the vector direction we want
      double theta = Math.Atan2(Direction.X, Direction.Y) + Math.PI / 2;
      float dirX = (float)Math.Sin(theta);
      float dirY = (float)Math.Cos(theta);
      AdditionalVelocity.X += dirX * moveSpeed * sideAxis;
      AdditionalVelocity.Y += dirY * moveSpeed * sideAxis;
      #endregion
      #region Rotation
      float cosRotSpeed = (float)Math.Cos(rotSpeed);
      float sinRotSpeed = (float)Math.Sin(rotSpeed);
      float olddirx = Direction.X;
      if (yawAxis != 0) Direction.X = (Direction.X * cosRotSpeed - Direction.Y * -sinRotSpeed) * yawAxis;
      if (yawAxis != 0) Direction.Y = (olddirx * -sinRotSpeed + Direction.Y * cosRotSpeed) * yawAxis;
      #endregion
      #region Modifiers 
      // TODO: Modifiers
      //// jump
      //if (keys.IsKeyDown(Keys.Space) && Position.Z == 0) Velocity.Z += 200;
      //// crouch
      //if (keys.IsKeyDown(Keys.LeftControl)) Velocity.setZ(-200 - position.z);
      //// Run
      //if (keys.IsKeyDown(Keys.LeftShift)) Velocity.mulScalar(2);
      #endregion
      #region ApplyMotion
      // Apply Dampening
      if (AdditionalVelocity.Length() > 0) {
        // Set new Velocity
        AdditionalVelocity.Normalize();
        Velocity.X = AdditionalVelocity.X * .5f;
        Velocity.Y = AdditionalVelocity.Y * .5f;
      } else {
        // Dappen Velocity
        float dampening = Position.Z == 0 ? 3f : 5f;
        Velocity.X /= dampening;
        Velocity.Y /= dampening;
      }
      // Update State
      if (Velocity.X != 0 || Velocity.Y != 0 || Velocity.Z != 0) {
        // Set Position
        float projectedX = Position.X + Velocity.X;
        float projectedY = Position.Y + Velocity.Y;
        if (world.getWall((int)projectedX, (int)Position.Y) == Texture.Air) Position.X = projectedX;
        if (world.getWall((int)Position.X, (int)projectedY) == Texture.Air) Position.Y = projectedY;
        return true;
      }
      return false;
      #endregion
    }
  }
  // Enemy Controller
  class EnemyController : Controller {
    // Properties
    private bool Boss;
    // Constructor
    public EnemyController (bool boss) {
      Boss = boss;
    }
    // Methods
    public override bool Update(TimeSpan gameTime, World world) {
      return false;
    }
  }
}