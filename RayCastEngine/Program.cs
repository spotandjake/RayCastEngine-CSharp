using System;
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
      Menu game = new Menu();
      game.Show();
      Application.Run(game);
    }
  }
}
