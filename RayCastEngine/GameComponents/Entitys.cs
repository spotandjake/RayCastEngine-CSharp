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
    public Vector Position;
    public Texture Texture;
    public bool Boss;
    // Constructor
    public Enemy(int xPos, int yPos, Texture texture, bool boss) {
      // Set Props
      x = xPos;
      y = yPos;
      Position = new Vector(xPos, yPos, 0); 
      Texture = texture;
      Boss = boss;
    }
    public void Update(Texture[,] worldMap, List<Player> players) {
      // TODO: Fix Implementation
      Player closestPlayer = null;
      double closestDistance = 0;
      for (int playerIndex = 0; playerIndex < players.Count; playerIndex++) {
        Player currentPlayer = players[playerIndex];
        double playerDistance = Position.distance(currentPlayer.Position);
        if (closestDistance == 0 || closestDistance < playerDistance) {
          closestDistance = playerDistance;
          closestPlayer = currentPlayer;
        }
      }
      if (closestPlayer != null)
        Console.WriteLine(closestPlayer.Position);
      else Console.WriteLine("There Is An Issue");
      // If Close To Player Head Towards
      // If Close To Player And Has Skills Attack
      // If Not Close To Player Patrol
    }
  }
  // Player
  public class Player {
    public Vector Position;
    public Vector Direction;
    public Texture Texture;
    public Player(Vector position, Vector direction, Texture texture) {
      // TODO: Implement Player Class
      Position = position;
      Direction = direction;
      Texture = texture;
    }
  }
}
