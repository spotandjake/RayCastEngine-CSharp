using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace RayCastEngine.GameComponents {
  public class DirectBitmap : IDisposable {
    public Bitmap Bitmap { get; private set; }
    public int[] Bits { get; private set; }
    public bool Disposed { get; private set; }
    public int Height { get; private set; }
    public int Width { get; private set; }

    protected GCHandle BitsHandle { get; private set; }

    public DirectBitmap(int width, int height, bool doBitMap) {
      Width = width;
      Height = height;
      Bits = new int[width * height];
      if (doBitMap) BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
      if (doBitMap) Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppArgb, BitsHandle.AddrOfPinnedObject());
    }
    public void fillColor(Color colour) {
      fillColor(colour.ToArgb());
    }
    public void fillColor(int colour) {
      for (int index = 0; index < Width * Height; index++) {
        Bits[index] = colour;
      }
    }
    public void SetPixel(int x, int y, Color colour) {
      SetPixel(x, y, colour.ToArgb());
    }
    public void SetPixel(int x, int y, byte red, byte green, byte blue) {
      SetPixel(x, y, 255, red, green, blue);
    }
    public void SetPixel(int x, int y, byte alpha, byte red, byte green, byte blue) {
      byte[] bytes = new byte[] { blue, green, red, alpha };
      SetPixel(x, y, BitConverter.ToInt32(bytes, 0));
    }
    public void SetPixel(int x, int y, int colour) {
      Bits[x + (y * Width)] = colour;
    }
    public Color GetPixel(int x, int y) {
      int index = x + (y * Width);
      try {
        int col = Bits[index];
        return Color.FromArgb(col);
      } catch (Exception) {
        return Color.Black;
      }
    }
    public int GetPixelInteger(int x, int y) {
      int index = x + (y * Width);
      try {
        return Bits[index];
      } catch (Exception) {
        return -16777216;
      }
    }
    public void Dispose() {
      if (Disposed) return;
      Disposed = true;
      Bitmap.Dispose();
      BitsHandle.Free();
    }

    // Create a Direct BitMap From A Normal Bitmap
    public static DirectBitmap fromBitmap(Bitmap bitMap, bool doBitMap) {
      // Create New DirectBitMap
      DirectBitmap directBitMap = new DirectBitmap(bitMap.Width, bitMap.Height, doBitMap);
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
