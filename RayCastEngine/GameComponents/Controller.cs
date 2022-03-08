using System;
using Microsoft.Xna.Framework;

namespace RayCastEngine.GameComponents {
  interface Controller {
    // Properties
    // Methods
    void Update(TimeSpan gameTime, Texture[,] worldMap, Sprite[] sprites);
  }
  // Networked Controller
  // Local Controller
  class LocalPlayer : Controller {
    // Properties
    Vector3 Position;
    Vector3 Direction;
    // Constructor
    // Methods
    public void Update(TimeSpan gameTime, Texture[,] worldMap, Sprite[] sprites) {

    }
  }
  // Enemy Controller
}