using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace RayCastEngine.GameComponents {
  interface Controller {
    // Properties
    // Methods
    bool Update(TimeSpan gameTime, World world);
  }
  // Networked Controller
  // Local Controller
  class LocalPlayerController : Controller {
    // Properties
    public Vector3 Position;
    public Vector3 Direction;
    private Vector3 Velocity;
    // Constructor
    // Methods
    public bool Update(TimeSpan gameTime, World world) {
      KeyboardState keys = Keyboard.GetState();
      int forwardAxis = 0;
      int sideAxis = 0;
      // We want to normalize movement over time so you move the same distance no matter the fps
      float frameTime = gameTime.Milliseconds / 1000.0f;
      // Normalized Move Speeds
      float moveSpeed = frameTime * 3; //the constant value is in squares/second
      float rotSpeed = frameTime * 2; //the constant value is in radians/second
      #region Convert Input Axis
      if (keys.IsKeyDown(Keys.W)) forwardAxis += 1;
      if (keys.IsKeyDown(Keys.S)) forwardAxis -= 1;
      if (keys.IsKeyDown(Keys.A)) sideAxis += 1;
      if (keys.IsKeyDown(Keys.D)) sideAxis -= 1;
      #endregion
      #region Movement
      // Forward
      Velocity.X += Direction.X * moveSpeed * forwardAxis;
      Velocity.Y += Direction.Y * moveSpeed * forwardAxis;
      #endregion
      #region Rotation
      #endregion
      #region Physics
      #endregion
      #region ApplyMotion
      if (Velocity.X != 0 || Velocity.Y != 0 || Velocity.Z != 0) {
        // Apply Motion
        float projectedX = Position.X + Velocity.X;
        float projectedY = Position.Y + Velocity.Y;
        if (world.getWall((int)projectedX, (int)Position.Y) == Texture.Air) Position.X = projectedX;
        if (world.getWall((int)Position.X, (int)projectedY) == Texture.Air) Position.Y = projectedY;
        // Return The Update State
        return true;
      }
      return false;
      #endregion
    }
  }
  // Enemy Controller
  class EnemyController : Controller {
    // Properties
    public Vector3 Position;
    public Vector3 Direction;
    private bool Boss;
    // Constructor
    public EnemyController (bool boss) {
      Boss = boss;
    }
    // Methods
    public bool Update(TimeSpan gameTime, World world) {
      return false;
    }
  }
}