using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    public DirectBitmap(int width, int height) {
      Width = width;
      Height = height;
      Bits = new int[width * height];
      BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
      Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppArgb, BitsHandle.AddrOfPinnedObject());
    }

    public void SetPixel(int x, int y, Color colour) {
      int index = x + (y * Width);
      int col = colour.ToArgb();
      Bits[index] = col;
    }

    public Color GetPixel(int x, int y) {
      int index = x + (y * Width);
      int col = Bits[index];
      return Color.FromArgb(col); ;
    }

    public void Dispose() {
      if (Disposed) return;
      Disposed = true;
      Bitmap.Dispose();
      BitsHandle.Free();
    }

    // Create a Direct BitMap From A Normal Bitmap
    public static DirectBitmap fromBitmap(Bitmap bitMap) {
      // Create New DirectBitMap
      DirectBitmap directBitMap = new DirectBitmap(bitMap.Width, bitMap.Height);
      // Set Data
      // TODO: Optimize This
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
