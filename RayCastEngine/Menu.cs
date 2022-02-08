using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    private void Menu_Exit(Object sender, System.EventArgs e) {
      this.Close();
    }
  }
}
