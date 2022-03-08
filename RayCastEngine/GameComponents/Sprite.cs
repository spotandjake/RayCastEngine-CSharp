using System;
using Microsoft.Xna.Framework;

namespace RayCastEngine.GameComponents {
  class Sprite {
    // Properties
    public Vector3 Position;
    public Vector3 Direction;
    public Texture Texture;
    private Controller Controller;
    // Tempory Stuff For Drawing
    // TODO: Move this out of the class
    public double distance;
    // Methods
    public Sprite(Vector3 position, Vector3 direction, Texture texture, Controller controller = null) {
      Position = position;
      Direction = direction;
      Texture = texture;
      Controller = controller;
    }
    // Update
    public void Update(TimeSpan gameTime, Texture[,] worldMap, Sprite[] sprites) {
      if (Controller != null) Controller.Update(gameTime, worldMap, sprites);
    }
  }
}
