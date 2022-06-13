using System;
using System.Threading.Tasks;
using RayCastEngine.Views;
using RayCastEngine.GameComponents;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RayCastEngine {
  public partial class FullGame : XNAWinForm {
    // Temp Props
    private bool Running = false;
    private GameType currentGameType;
    private Engine currentEngine;
    private SpriteBatch screenSprite;
    // Buffers
    private DirectBitmap SceneBuffer;
    private DirectBitmap SpriteBuffer;
    private DirectBitmap UiBuffer;
    // Buffer Textures
    private Texture2D SceneBufferTexture;
    private Texture2D SpriteBufferTexture;
    private Texture2D UiBufferTexture;
    
    // XNA STuff
    public FullGame() {
      InitializeComponent();
      DeviceReset += new GraphicsDeviceDelegate(mWinForm_DeviceReset);
      OnFrameRender += new GraphicsDeviceDelegate(mWinForm_OnFrameRender);
      // Initialize Stuff
      // Start SinglePlayer
      singlePlayer();
    }
    // Draw Menu
    // Menu
    private void singlePlayer() {
      // GameType
      currentGameType = GameType.SinglePlayer;
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
      while (Running) {
        // Calculate the time elapsed since the last game loop cycle
        TimeSpan GameTime = DateTime.Now - _previousGameTime;
        // Update the current previous game time
        _previousGameTime = _previousGameTime + GameTime;
        // Update the game
        if (this.Focused) {
          bool update = currentEngine.Update(GameTime);
          if (update) {
            // Check if the state changed
            SceneBuffer = currentEngine.DrawScene(GameTime);
            SpriteBuffer = currentEngine.DrawSprites(GameTime);
            UiBuffer = currentEngine.DrawUi(GameTime);
            Invalidate();
            Update();
          }
          DataView.Text = currentEngine.getDataText(GameTime);
        }
        // Update Game at 120fps
        await Task.Delay(1000 / 240);
      }
    }
    // Deal With Resize
    private void Game_Resize(object sender, EventArgs e) {
      this.panelViewport.Size = new System.Drawing.Size(Width, Height);
    }
    // Close Window
    private void Game_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e) {
      Environment.Exit(Environment.ExitCode);
      //System.Windows.Forms.Application.Exit();
    }
    // XNA
    void mWinForm_OnFrameRender(GraphicsDevice pDevice) {
      // If The Game Has Started
      if (SceneBuffer != null && UiBuffer != null) {
        // Initialize Our SpriteBatch
        if (screenSprite == null)
          screenSprite = new SpriteBatch(pDevice);
        // If We Need To Resize Our Texture
        if (SceneBufferTexture == null || SceneBufferTexture.Bounds.Width != SceneBuffer.Width || SceneBufferTexture.Bounds.Height != SceneBuffer.Height)
          SceneBufferTexture = new Texture2D(pDevice, SceneBuffer.Width, SceneBuffer.Height);
        if (SpriteBufferTexture == null || SpriteBufferTexture.Bounds.Width != SpriteBuffer.Width || SpriteBufferTexture.Bounds.Height != SpriteBuffer.Height)
          SpriteBufferTexture = new Texture2D(pDevice, SpriteBuffer.Width, SpriteBuffer.Height);
        if (UiBufferTexture == null || UiBufferTexture.Bounds.Width != UiBuffer.Width || UiBufferTexture.Bounds.Height != UiBuffer.Height)
          UiBufferTexture = new Texture2D(pDevice, UiBuffer.Width, UiBuffer.Height);
        // Draw To Our Textures
        Device.Textures[0] = null;
        SceneBufferTexture.SetData(SceneBuffer.Bits);
        Device.Textures[0] = null;
        SpriteBufferTexture.SetData(SpriteBuffer.Bits);
        Device.Textures[0] = null;
        UiBufferTexture.SetData(UiBuffer.Bits);
        // Draw our Buffers to the screen
        screenSprite.Begin();
        // Draw our Scene
        screenSprite.Draw(SceneBufferTexture, new Rectangle(0, 0, SceneBuffer.Width, SceneBuffer.Height), Color.White);
        // Draw Our Sprite
        screenSprite.Draw(SpriteBufferTexture, new Rectangle(0, 0, SpriteBuffer.Width, SpriteBuffer.Height), Color.White);
        // Draw Our Ui
        screenSprite.Draw(UiBufferTexture, new Rectangle(0, 0, UiBuffer.Width, UiBuffer.Height), Color.White);
        screenSprite.End();
      }
    }

    void mWinForm_DeviceReset(GraphicsDevice pDevice) {
      pDevice.RasterizerState = RasterizerState.CullNone;
    }
  }
}
