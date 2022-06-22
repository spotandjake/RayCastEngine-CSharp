using System;
using System.Windows.Forms;

namespace RayCastEngine {
  public partial class Menu : Form {
    // Properties
    // Methods
    public Menu() {
      // Initialize
      InitializeComponent();
    }
    // Menu Keyboard Handler
    private void Menu_KeyUp(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.F11:
          // Full Screen
          if (FormBorderStyle == FormBorderStyle.None) {
            FormBorderStyle = FormBorderStyle.Sizable;
          } else {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
          }
          break;
      }
    }
    // Menu Buttons
    // TODO: Implement Other Buttons
    private void Menu_SinglePlayer(Object sender, System.EventArgs e) {
      this.Hide();
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
    private void Menu_Exit(Object sender, System.EventArgs e) {
      this.Close();
    }
  }
}
