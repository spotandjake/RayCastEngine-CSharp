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
    public void addScalar(double scalar) {
      x += scalar;
      y += scalar;
      z += scalar;
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
    public void subScalar(double scalar) {
      x -= scalar;
      y -= scalar;
      z -= scalar;
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
    public void mul(Vector vec) {
      x *= vec.x;
      y *= vec.y;
      z *= vec.y;
    }
    public void mulScalar(double scalar) {
      x *= scalar;
      y *= scalar;
      z *= scalar;
    }
    public void mulXYZ(double xVal, double yVal, double zVal) {
      x *= xVal;
      y *= yVal;
      z *= zVal;
    }
    public void mulX(double xVal) {
      x *= xVal;
    }
    public void mulY(double yVal) {
      y *= yVal;
    }
    public void mulZ(double zVal) {
      z *= zVal;
    }
    public void div(Vector vec) {
      x /= vec.x;
      y /= vec.y;
      z /= vec.y;
    }
    public void divScalar(double scalar) {
      x /= scalar;
      y /= scalar;
      z /= scalar;
    }
    public void divXYZ(double xVal, double yVal, double zVal) {
      x /= xVal;
      y /= yVal;
      z /= zVal;
    }
    public void divX(double xVal) {
      x /= xVal;
    }
    public void divY(double yVal) {
      y /= yVal;
    }
    public void divZ(double zVal) {
      z /= zVal;
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
    public Vector getMul(Vector vec) {
      return new Vector(x * vec.x, y * vec.y, z * vec.z);
    }
    public Vector getMulXYZ(double xVal, double yVal, double zVal) {
      return new Vector(x * xVal, y * yVal, z * zVal);
    }
    public Vector getDiv(Vector vec) {
      return new Vector(x / vec.x, y / vec.y, z / vec.z);
    }
    public Vector getDivXYZ(double xVal, double yVal, double zVal) {
      return new Vector(x / xVal, y / yVal, z / zVal);
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