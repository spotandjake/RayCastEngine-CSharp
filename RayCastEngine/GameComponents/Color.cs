using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCastEngine.GameComponents {
  public class Color {
    // Properties
    public int r;
    public int g;
    public int b;
    public int a;
    // Constructor
    public Color(int red, int green, int blue, int alpha) {
      r = red;
      g = green;
      b = blue;
      a = alpha;
    }
    // Functions
    int[] toArray() {
      return new int[3][r, g, b, a];
    }
  }
}
