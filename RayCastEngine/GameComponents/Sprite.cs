using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCastEngine.GameComponents {
  public class Sprite {
    // Properties
    public double distance;
    public double x;
    public double y;
    public Texture texture;
    // Constructor
    void main(double xPos, double yPos, Texture tex) {
      x = xPos;
      y = yPos;
      texture = tex;
    }
  }
}
