using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayCastEngine {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      // Create window and show it
      FullGame game = new FullGame();
      game.Show();

      // Loop while created
      while (game.Created) {
        // If RefreshMode is "always" explicitly call the Render method each pass
        if (game.RefreshMode == XNAWinForm.eRefreshMode.Always)
          game.Render();

        // Let windows do it´s magic
        Application.DoEvents();
      }
    }
  }
}
