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
    // Non Modifying Functions
    public Vector3 getAdd(Vector3 vec) {
      return new Vector3(x + vec.x, y + vec.y, z + vec.z);
    }
    public Vector3 getAddXYZ(double xVal, double yVal, double zVal) {
      return new Vector3(x + xVal, y + yVal, z + zVal);
    }
    public Vector3 getSub(Vector3 vec) {
      return new Vector3(x - vec.x, y - vec.y, z - vec.z);
    }
    public Vector3 getSubXYZ(double xVal, double yVal, double zVal) {
      return new Vector3(x - xVal, y - yVal, z - zVal);
    }
    public double length() {
      return Math.Sqrt(x * x + y * y + z * z);
    }
    public double distance(Vector3 target) {
      return getSub(target).length();
    }
    // Functions
    public double[] toArray() {
      return new double[] { x, y, z };
    }
  }
}
