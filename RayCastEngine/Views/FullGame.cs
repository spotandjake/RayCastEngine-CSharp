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
    // XNA STuff
    private float mRotation = 0f;
    private Matrix mViewMat, mWorldMat, mProjectionMat;
    private BasicEffect mSimpleEffect;
    VertexPositionColor[] triVerts = new VertexPositionColor[] {
            new VertexPositionColor(Vector3.Zero*2, Color.Blue),
            new VertexPositionColor(Vector3.Right*2, Color.Green),
            new VertexPositionColor(Vector3.Up*2, Color.Red)};
    public FullGame() {
      InitializeComponent();
      this.DeviceResetting += new EmptyEventHandler(mWinForm_DeviceResetting);
      this.DeviceReset += new GraphicsDeviceDelegate(mWinForm_DeviceReset);
      this.OnFrameRender += new GraphicsDeviceDelegate(mWinForm_OnFrameRender);
      this.OnFrameMove += new GraphicsDeviceDelegate(FullGame_OnFrameMove);
      mViewMat = mWorldMat = mProjectionMat = Matrix.Identity;
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
      //Graphics gfx = this.CreateGraphics();
      // Optimize Rendering Speed
      //gfx.CompositingMode = CompositingMode.SourceCopy;
      //gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
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
    //private void Game_onPaint(object sender, PaintEventArgs e) {
    //  if (buffer != null)
    //    e.Graphics.DrawImage(buffer.Bitmap, new Point(0, 0));
    //}
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
    public static Texture2D GetTexture2DFromBitmap(GraphicsDevice device, DirectBitmap bitmap) {
      Texture2D tex = new Texture2D(device, bitmap.Width, bitmap.Height);
      // copy our buffer to the texture
      tex.SetData(bitmap.Bits);
      return tex;
    }
    void FullGame_OnFrameMove(GraphicsDevice pDevice) {
      mRotation += 0.1f;
      this.mWorldMat = Matrix.CreateRotationY(mRotation);
    }
    void mWinForm_OnFrameRender(GraphicsDevice pDevice) {
      //mSimpleEffect.World = this.mWorldMat;
      //mSimpleEffect.View = this.mViewMat;
      //mSimpleEffect.Projection = this.mProjectionMat;
      //mSimpleEffect.DiffuseColor = Color.DarkRed.ToVector3();
      //mSimpleEffect.Techniques[0].Passes[0].Apply();
      //pDevice.DrawUserPrimitives(PrimitiveType.TriangleList, triVerts, 0, 1);
      // TODO: Implement Drawing
      if (buffer != null) {
        Texture2D drawing = GetTexture2DFromBitmap(Device, buffer);
        SpriteBatch screen = new SpriteBatch(Device);
        screen.Begin();
        screen.Draw(drawing, new Rectangle(0, 0, Width, Height), Color.AliceBlue);
        screen.End();
      }
    }

    void mWinForm_DeviceReset(GraphicsDevice pDevice) {
      mSimpleEffect = new BasicEffect(pDevice);
      pDevice.RasterizerState = RasterizerState.CullNone;
      mWorldMat = Matrix.Identity;
      mViewMat = Matrix.CreateLookAt(Vector3.Backward * 10, Vector3.Zero, Vector3.Up);
      mProjectionMat = Matrix.CreatePerspectiveFieldOfView(MathHelper.Pi / 4.0f,
              (float)pDevice.PresentationParameters.BackBufferWidth / (float)pDevice.PresentationParameters.BackBufferHeight,
              1.0f, 100.0f);
    }
    void mWinForm_DeviceResetting() {
      // Dispose all
      if (mSimpleEffect != null)
        mSimpleEffect.Dispose();
    }
  }
}
