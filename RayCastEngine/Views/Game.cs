﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    private Boolean Running = false;
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
      if (currentEngine == null)
        throw new ArgumentException("Game not loaded!");

      // Load game content
      currentEngine.Load(currentGameType);

      // Set gameloop state
      Running = true;

      // Set previous game time
      DateTime _previousGameTime = DateTime.Now;
      int NormalFrameTime = 1000 / 60;
      while (Running) {
        // Calculate the time elapsed since the last game loop cycle
        TimeSpan GameTime = DateTime.Now - _previousGameTime;
        // Update the current previous game time
        _previousGameTime = _previousGameTime + GameTime;
        // Update List Of Keys
        currentEngine.keys = keys;
        // Update the game
        currentEngine.Update(GameTime);
        // Draw Frame
        currentEngine.Draw(gfx, GameTime);
        // Update Game at 60fps
        int elapsedTime = (DateTime.Now - GameTime).Millisecond;
        if (elapsedTime < NormalFrameTime) {
          await Task.Delay(NormalFrameTime - elapsedTime);
        }
      }
    }
    // Keys
    private void Menu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
      if (keys.ContainsKey((int)e.KeyCode)) keys[(int)e.KeyCode] = true;
      else keys.Add((int)e.KeyCode, true);
    }
    private void Menu_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e) {
      if (keys.ContainsKey((int)e.KeyCode)) keys[(int)e.KeyCode] = false;
      else keys.Add((int)e.KeyCode, false);
    }
  }
}
