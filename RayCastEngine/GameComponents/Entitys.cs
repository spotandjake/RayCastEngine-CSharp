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
    public int x;
    public int y;
    public Texture Texture;
    public bool Boss;
    // Constructor
    public Enemy(int xPos, int yPos, Texture texture, bool boss) {
      // Set Props
      x = xPos;
      y = yPos;
      Texture = texture;
      Boss = boss;
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
