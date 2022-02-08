using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using RayCastEngine.Views;

namespace RayCastEngine.GameComponents {
  class Engine {
    // Properties
    public Size Resolution { get; set; }
    // Methods
    public void Load(GameType gameType) {
      // Initialize
    }
    public void Update(TimeSpan gameTime) {
      // Gametime elapsed
      double gameTimeElapsed = gameTime.TotalMilliseconds / 1000;
      // Draw Frame Into Buffer
    }
    public void Draw(Graphics gfx) {
      // Draw Our New Buffer
      gfx.FillRectangle(new SolidBrush(Color.CornflowerBlue), new Rectangle(0, 0, Resolution.Width, Resolution.Height));
    }
  }
}
