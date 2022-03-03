using System;
using System.Collections.Generic;
using RayCastEngine.GameComponents;


using XNA = Microsoft.Xna.Framework;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace RayCastEngine {
  public partial class FullGame : XNAWinForm {
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
    }
    // Menu
    // Game Loop
    private Dictionary<int, bool> keys = new Dictionary<int, bool>();
    private bool Running = false;
    private GameType currentGameType;
    private Engine currentEngine;
    private DirectBitmap buffer;
    // XNA
    void FullGame_OnFrameMove(GraphicsDevice pDevice) {
      mRotation += 0.1f;
      this.mWorldMat = Matrix.CreateRotationY(mRotation);
    }
    void mWinForm_OnFrameRender(GraphicsDevice pDevice) {
      mSimpleEffect.World = this.mWorldMat;
      mSimpleEffect.View = this.mViewMat;
      mSimpleEffect.Projection = this.mProjectionMat;
      mSimpleEffect.DiffuseColor = Color.DarkRed.ToVector3();
      mSimpleEffect.Techniques[0].Passes[0].Apply();
      pDevice.DrawUserPrimitives(PrimitiveType.TriangleList, triVerts, 0, 1);
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
