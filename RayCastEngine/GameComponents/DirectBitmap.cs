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
    public void clearImage() {
      Array.Clear(Bits, 0, Bits.Length);
    }
    public void fillColor(Color colour) {
      Parallel.For(0, Width * Height, index => {
        Bits[index] = colour;
      });
    }
    public void SetPixel(int x, int y, Color colour) {
      Bits[x + (y * Width)] = colour;
    }
    public Color GetPixel(int x, int y) {
      int index = x + (y * Width);
      return Bits[index];
    }
    // Create a Direct BitMap From A Normal Bitmap
    public static DirectBitmap fromBitmap(System.Drawing.Bitmap bitMap) {
      // Create New DirectBitMap
      DirectBitmap directBitMap = new DirectBitmap(bitMap.Width, bitMap.Height);
      // Set Data
      for (int x = 0; x < bitMap.Width; x++) {
        for (int y = 0; y < bitMap.Height; y++) {
          System.Drawing.Color color = bitMap.GetPixel(x, y);
          directBitMap.SetPixel(
            x,
            y,
            new Color(color.R, color.G, color.B, color.A)
          );
        }
      }
      // Return New Value
      return directBitMap;
    }
  }
}
