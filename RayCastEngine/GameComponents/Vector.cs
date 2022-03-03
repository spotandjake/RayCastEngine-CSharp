using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCastEngine.GameComponents {
  public class Vector {
    // Properties
    public double x;
    public double y;
    public double z;
    // Constructor
    public Vector(double xVal, double yVal, double zVal) {
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
    public Vector copy() {
      return new Vector(x, y, z);
    }
    // Math Methods
    public bool equals(Vector vec) {
      return x == vec.x && y == vec.y && z == vec.z;
    }
    public void add(Vector vec) {
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
    public void sub(Vector vec) {
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
    // Non Modifying Functions
    public Vector getAdd(Vector vec) {
      return new Vector(x + vec.x, y + vec.y, z + vec.z);
    }
    public Vector getAddXYZ(double xVal, double yVal, double zVal) {
      return new Vector(x + xVal, y + yVal, z + zVal);
    }
    public Vector getSub(Vector vec) {
      return new Vector(x - vec.x, y - vec.y, z - vec.z);
    }
    public Vector getSubXYZ(double xVal, double yVal, double zVal) {
      return new Vector(x - xVal, y - yVal, z - zVal);
    }
    public double length() {
      return Math.Sqrt(x * x + y * y + z * z);
    }
    public double distance(Vector target) {
      return getSub(target).length();
    }
    // Functions
    public double[] toArray() {
      return new double[] { x, y, z };
    }
  }
}