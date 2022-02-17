using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RayCastEngine.GameComponents;

namespace RayCastEngine.Views {
  // Game Runtime
  public partial class Game : Form {
    // Properties
    private Dictionary<int, bool> keys = new Dictionary<int, bool>();
    private bool Running = false;
    private bool RanLastFrame = false;
    private int interlaceAmmount = 2;
    private GameType currentGameType;
    private Engine currentEngine;
    // Form Entry
    public Game(GameType gameType) {
      // GameType
      currentGameType = gameType;
      // Initalize
      InitializeComponent();
      // Lock To FullScreen
      WindowState = FormWindowState.Maximized;
      // Create Game
      currentEngine = new Engine();
      Rectangle resolution = Screen.PrimaryScreen.Bounds;
      currentEngine.Resolution = new Size(resolution.Width, resolution.Height);
      // Start
      Start();
    }
    /// <summary>
    /// Start GameLoop
    /// </summary>
    public async void Start() {
      Graphics gfx = this.CreateGraphics();
      // Optimize Rendering Speed
      gfx.CompositingMode = CompositingMode.SourceCopy;
      gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
      // Make Sure We Load A Game
      if (currentEngine == null)
        throw new ArgumentException("Game not loaded!");

      // Load game content
      currentEngine.Load(currentGameType);

      // Set gameloop state
      Running = true;

      // Set previous game time
      DateTime _previousGameTime = DateTime.Now;
      while (Running) {
        // Calculate the time elapsed since the last game loop cycle
        TimeSpan GameTime = DateTime.Now - _previousGameTime;
        // Update the current previous game time
        _previousGameTime = _previousGameTime + GameTime;
        // Update List Of Keys
        currentEngine.keys = keys;
        // Update the game
        currentEngine.Update(GameTime);
        // Check if the state changed
        if (currentEngine.GameStateChanged) {
          // Update The Screen
          currentEngine.UpdateScreen(GameTime, interlaceAmmount);
          currentEngine.Draw(gfx, GameTime);
          // Set The Update Cycle To False
          RanLastFrame = true;
          currentEngine.GameStateChanged = false;
        } else if (RanLastFrame) {
          currentEngine.UpdateScreen(GameTime, 1);
          currentEngine.Draw(gfx, GameTime);
          RanLastFrame = false;
        }
        DataView.Text = currentEngine.getDataText(GameTime);
        // Update Game at 120fps
        await Task.Delay(1000 / 240);
      }
    }
    // Close Window
    private void Game_FormClosed(object sender, FormClosedEventArgs e) {
      Application.Exit();
    }
    // Keys
    private void Game_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
      if (keys.ContainsKey((int)e.KeyCode)) keys[(int)e.KeyCode] = true;
      else keys.Add((int)e.KeyCode, true);
    }
    private void Game_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e) {
      if (keys.ContainsKey((int)e.KeyCode)) keys[(int)e.KeyCode] = false;
      else keys.Add((int)e.KeyCode, false);
    }
  }
}
