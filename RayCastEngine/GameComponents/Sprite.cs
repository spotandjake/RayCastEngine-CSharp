using System;
using Microsoft.Xna.Framework;

namespace RayCastEngine.GameComponents {
  class Sprite {
    // Properties
    public Vector3 Position;
    public Vector3 Direction; // dirX, dirY, camPitch
    public Texture Texture;
    public bool Render;
    public Controller Controller;
    // Tempory Stuff For Drawing
    // TODO: Move this out of the class
    public double distance;
    // Methods
    public Sprite(Vector3 position, Vector3 direction, Texture texture, bool Render, Controller controller = null) {
      Position = position;
      Direction = direction;
      Texture = texture;
      Controller = controller;
      // Init
      if (Controller != null)  Controller.Initialize(Position, Direction);
    }
    // Update
    public void Update(TimeSpan gameTime, World world) {
      if (Controller != null) {
        // TODO: Handle If There Is An Update
        Controller.Update(gameTime, world);
        Position = Controller.Position;
        Direction = Controller.Direction;
      }
    }
  }
}
