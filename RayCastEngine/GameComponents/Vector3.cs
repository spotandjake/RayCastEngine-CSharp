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
    // Set Methods
    public void setX(double xVal) {
      x = xVal;
    }
    public void setY(double yVal) {
      y = yVal;
    }
    public void setZ(double zVal) {
      z = zVal;
    }
    public Vector3 copy() {
      return new Vector3(x, y, z);
    }
    // Math Methods
    public bool equals(Vector3 vec) {
      return x == vec.x && y == vec.y && z == vec.z;
    }
    public void add(Vector3 vec) {
      x += vec.x;
      y += vec.y;
      z += vec.y;
    }
    public void addXYZ(double xVal, double yVal, double zVal) {
      x += xVal;
      y += yVal;
      z += zVal;
    }
    public void addX(double xVal) {
      x += xVal;
    }
    public void addY(double yVal) {
      y += yVal;
    }
    public void addZ(double zVal) {
      z += zVal;
    }
    public void sub(Vector3 vec) {
      x -= vec.x;
      y -= vec.y;
      z -= vec.y;
    }
    public void subXYZ(double xVal, double yVal, double zVal) {
      x -= xVal;
      y -= yVal;
      z -= zVal;
    }
    public void subX(double xVal) {
      x -= xVal;
    }
    public void subY(double yVal) {
      y -= yVal;
    }
    public void subZ(double zVal) {
      z -= zVal;
    }
    // Functions
    public double[] toArray() {
      return new double[] { x, y, z };
    }
  }
}
