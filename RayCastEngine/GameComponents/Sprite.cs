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
    public float health = 100f; // TODO: Set This Based On Sprite
    // Tempory Stuff For Drawing
    // TODO: Move this out of the class
    public float distance;
    // Methods
    public Sprite(Vector3 position, Vector3 direction, Texture texture, bool render, Controller controller = null) {
      Position = position;
      Direction = direction;
      Texture = texture;
      Render = render;
      Controller = controller;
      // Init
      if (Controller != null)  Controller.Initialize(Position, Direction, this);
    }
    // Update
    public WorldUpdateResult Update(TimeSpan gameTime, World world) {
      if (Controller != null) {
        // TODO: Handle If There Is An Update
        WorldUpdateResult result = Controller.Update(gameTime, world, health);
        Position = Controller.Position;
        Direction = Controller.Direction;
        return result;
      }
      return new WorldUpdateResult {
        SceneUpdate = false,
        SpriteUpdate = false,
        UiUpdate = false,
        removeSelf = this.health <= 0,
      };
    }
    // Handle health
    public void lowerHealth(float damage) {
      this.health -= damage;
    }
  }
}
