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
    }
    private void Menu_Exit(Object sender, System.EventArgs e) {
      this.Close();
    }
  }
}
