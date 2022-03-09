using System;
using Microsoft.Xna.Framework;

namespace RayCastEngine.GameComponents {
  class Sprite {
    // Properties
    public Vector3 Position;
    public Vector3 Direction;
    public Texture Texture;
    public bool Render;
    private Controller Controller;
    // Tempory Stuff For Drawing
    // TODO: Move this out of the class
    public double distance;
    // Methods
    public Sprite(Vector3 position, Vector3 direction, Texture texture, bool Render, Controller controller = null) {
      Position = position;
      Direction = direction;
      Texture = texture;
      Controller = controller;
    }
    // Update
    public void Update(TimeSpan gameTime, World world) {
      if (Controller != null) Controller.Update(gameTime, world);
    }
  }
}
