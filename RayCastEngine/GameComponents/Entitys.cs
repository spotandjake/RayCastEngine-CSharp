using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCastEngine.GameComponents {
  // Sprites
  public class Sprite {
    // Properties
    public double distance;
    public double x;
    public double y;
    public Texture texture;
    // Constructor
    public Sprite(double xPos, double yPos, Texture tex) {
      x = xPos;
      y = yPos;
      texture = tex;
    }
  }
  // Enemys
  public class Enemy {
    public Vector3 Position;
    public Vector3 Direction;
    public Texture Texture;
    // Constructor
    public Enemy(Vector3 position, Vector3 direction, Texture texture) {
      // Set Props
      position = Position;
      direction = Direction;
      Texture = texture;
    }
    public void Update() {
      // TODO: Implement Update
    }
  }
  // Player
  public class Player {
    public Vector3 Position;
    public Vector3 Direction;
    public Texture Texture;
    public Player() {
      // TODO: Implement Player Class
    }
  }
}
