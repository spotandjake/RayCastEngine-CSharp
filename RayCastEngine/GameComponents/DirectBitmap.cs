using System;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;

namespace RayCastEngine.GameComponents {
  public class DirectBitmap {
    public Color[] Bits { get; private set; }
    public int Height { get; private set; }
    public int Width { get; private set; }

    public DirectBitmap(int width, int height) {
      Width = width;
      Height = height;
      Bits = new Color[width * height];
    }
    public void fillColor(Color colour) {
      Parallel.For(0, Width * Height, index => {
        Bits[index] = colour;
      });
    }
    public void SetPixel(int x, int y, Color colour) {
      //SetPixel(x, y, colour.ToArgb());
      Bits[x + (y * Width)] = colour;
    }
    public Color GetPixel(int x, int y) {
      int index = x + (y * Width);
      try {
        return Bits[index];
      } catch (Exception) {
        return Color.Black;
      }
    }
    // Create a Direct BitMap From A Normal Bitmap
    public static DirectBitmap fromBitmap(System.Drawing.Bitmap bitMap, bool doBitMap) {
      // Create New DirectBitMap
      DirectBitmap directBitMap = new DirectBitmap(bitMap.Width, bitMap.Height);
      // Set Data
      for (int x = 0; x < bitMap.Width; x++) {
        for (int y = 0; y < bitMap.Height; y++) {
          directBitMap.SetPixel(
            x,
            y,
            bitMap.GetPixel(x, y)
          );
        }
      }
      // Return New Value
      return directBitMap;
    }

  }
}
