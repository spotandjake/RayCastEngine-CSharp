using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCastEngine.GameComponents {
  public class Vector3 {
    // Properties
    public double x;
    public double y;
    public double z;
    // Constructor
    public Vector3(double xVal, double yVal, double zVal) {
      x = xVal;
      y = yVal;
      z = zVal;
    }
    // Functions
    int[] toArray() {
      return new int[2][x, y, z];
    }
  }
}
