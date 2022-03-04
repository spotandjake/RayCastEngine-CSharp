using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RayCastEngine.Views;
using RayCastEngine.GameComponents;

using XNA = Microsoft.Xna.Framework;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace RayCastEngine {
  public partial class FullGame : XNAWinForm {
    // Temp Props
    private Dictionary<int, bool> keys = new Dictionary<int, bool>();
    private bool Running = false;
    private GameType currentGameType;
    private Engine currentEngine;
    private DirectBitmap buffer;
    private Texture2D bufferTexture;
    private SpriteBatch screenSprite;
    // XNA STuff
    public FullGame() {
      InitializeComponent();
      this.DeviceResetting += new EmptyEventHandler(mWinForm_DeviceResetting);
      this.DeviceReset += new GraphicsDeviceDelegate(mWinForm_DeviceReset);
      this.OnFrameRender += new GraphicsDeviceDelegate(mWinForm_OnFrameRender);
      // Initialize Stuff
      // Start SinglePlayer
      singlePlayer();
    }
    // Menu
    private void singlePlayer() {
      // GameType
      currentGameType = GameType.SinglePlayer;
      // Lock To FullScreen
      //WindowState = FormWindowState.Maximized;
      // Create Game
      currentEngine = new Engine();
      // Start
      Start();
    }
    // Game Loop
    /// <summary>
    /// Start GameLoop
    /// </summary>
    public async void Start() {
      // Make Sure We Load A Game
      if (currentEngine == null)
        throw new ArgumentException("Game not loaded!");

      // Load game content
      currentEngine.Load(currentGameType);
      // Load Size
      currentEngine.Resize(Width, Height);
      // Set gameloop state
      Running = true;

      // Set previous game time
      DateTime _previousGameTime = DateTime.Now;
      currentEngine.GameStateChanged = true;
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
          currentEngine.UpdateScreen(GameTime);
          buffer = currentEngine.Draw(GameTime);
          Invalidate();
          Update();
          // Set The Update Cycle To False
          currentEngine.GameStateChanged = false;
        }
        DataView.Text = currentEngine.getDataText(GameTime);
        // Update Game at 120fps
        await Task.Delay(1000 / 240);
      }
    }
    // OnPaint
    // Deal With Resize
    private void Game_Resize(object sender, EventArgs e) {
      this.panelViewport.Size = new System.Drawing.Size(Width, Height);
      // Load Size
      currentEngine.Resize(Width, Height);
    }
    // Close Window
    //private void Game_FormClosed(object sender, FormClosedEventArgs e) {
    //  Application.Exit();
    //}
    // Keys
    private void Game_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
      if (keys.ContainsKey((int)e.KeyCode)) keys[(int)e.KeyCode] = true;
      else keys.Add((int)e.KeyCode, true);
    }
    private void Game_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e) {
      if (keys.ContainsKey((int)e.KeyCode)) keys[(int)e.KeyCode] = false;
      else keys.Add((int)e.KeyCode, false);
    }
    // XNA
    void mWinForm_OnFrameRender(GraphicsDevice pDevice) {
      if (buffer != null) {
        bufferTexture = new Texture2D(Device, buffer.Width, buffer.Height);
        bufferTexture.SetData(buffer.Bits);
        screenSprite = new SpriteBatch(pDevice);
        screenSprite.Begin();
        screenSprite.Draw(bufferTexture, new Rectangle(0, 0, buffer.Width, buffer.Height), Color.White);
        screenSprite.End();
      }
    }

    void mWinForm_DeviceReset(GraphicsDevice pDevice) {
      pDevice.RasterizerState = RasterizerState.CullNone;
    }
    void mWinForm_DeviceResetting() {
    }
  }
}
