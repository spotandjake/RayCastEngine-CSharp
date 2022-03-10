﻿using System;
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
      bool Running = false;
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
      if (keys.IsKeyDown(Keys.Up)) pitchAxis += 1;
      if (keys.IsKeyDown(Keys.Down)) pitchAxis -= 1;
      #endregion
      Vector3 AdditionalVelocity = Vector3.Zero;
      #region Movement
      if (Position.Z < 0.25f && Position.Z > -0.25f)
        Position.Z = 0;
      else if (Position.Z > 0)
        Velocity.Z = Position.Z * -2f;
      else if (Position.Z < 0)
        Velocity.Z = Position.Z * -2f;
      #endregion
      #region Movement
      // Strafe Right
      // TODO: Figure out how to remove the need for conversion here
      double theta = Math.Atan2(Direction.X, Direction.Y) + Math.PI / 2;
      float dirX = (float)Math.Sin(theta);
      float dirY = (float)Math.Cos(theta);
      // Forward
      // TODO: Merge This with side to side, possibly by using a normalized vector as our axis
      AdditionalVelocity.X += Direction.X * moveSpeed * forwardAxis + dirX * moveSpeed * sideAxis;
      AdditionalVelocity.Y += Direction.Y * moveSpeed * forwardAxis + dirY * moveSpeed * sideAxis;
      #endregion
      #region Rotation
      float cosRotSpeed = (float)Math.Cos(rotSpeed);
      float sinRotSpeed = (float)Math.Sin(rotSpeed) * yawAxis;
      float olddirx = Direction.X, oldPlaneX = Plane.X;
      if (yawAxis != 0) {
        Direction.X = (Direction.X * cosRotSpeed - Direction.Y * -sinRotSpeed);
        Direction.Y = (olddirx * -sinRotSpeed + Direction.Y * cosRotSpeed);
        Plane.X = (Plane.X * cosRotSpeed - Plane.Y * -sinRotSpeed);
        Plane.Y = (oldPlaneX * -sinRotSpeed + Plane.Y * cosRotSpeed);
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
      // TODO: Modifiers
      //// jump
      if (keys.IsKeyDown(Keys.Space) && Position.Z == 0) Velocity.Z += 200;
      //// crouch
      if (keys.IsKeyDown(Keys.LeftControl)) Velocity.Z -= 200;
      //// Run
      if (keys.IsKeyDown(Keys.LeftShift)) Running = true;
      #endregion
      #region ApplyMotion
      // Apply Dampening
      if (AdditionalVelocity.Length() > 0) {
        // Set new Velocity
        AdditionalVelocity.Normalize();
        Velocity.X = AdditionalVelocity.X * (Running ? .3f : .2f);
        Velocity.Y = AdditionalVelocity.Y * (Running ? .3f : .2f);
        Velocity.Z = AdditionalVelocity.Z * (Running ? .3f : .2f);
      } else {
        // Dappen Velocity
        float dampening = Position.Z == 0 ? 3f : 5f;
        Velocity.X /= dampening;
        Velocity.Y /= dampening;
        Velocity.Z /= dampening;
      }
      // Update State
      if (Velocity.X != 0 || Velocity.Y != 0 || Velocity.Z != 0) {
        // Set Position
        float projectedX = Position.X + Velocity.X;
        float projectedY = Position.Y + Velocity.Y;
        if (world.getWall((int)projectedX, (int)Position.Y) == Texture.Air) Position.X = projectedX;
        if (world.getWall((int)Position.X, (int)projectedY) == Texture.Air) Position.Y = projectedY;
        Position.Z += Velocity.Z;
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