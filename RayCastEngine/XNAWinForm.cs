using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RayCastEngine {
  public partial class XNAWinForm : Form {
    public enum eRefreshMode {
      Always,
      OnPanelPaint,
    }

    private GraphicsDevice mDevice;
    public GraphicsDevice Device {
      get { return mDevice; }
    }
    private eRefreshMode mRefreshMode = eRefreshMode.Always;
    public eRefreshMode RefreshMode {
      get { return mRefreshMode; }
      set {
        mRefreshMode = value;
      }
    }
    private Microsoft.Xna.Framework.Color mBackColor = Microsoft.Xna.Framework.Color.AliceBlue;

    #region Events
    public delegate void GraphicsDeviceDelegate(GraphicsDevice pDevice);
    public delegate void EmptyEventHandler();
    public event GraphicsDeviceDelegate OnFrameRender = null;
    public event GraphicsDeviceDelegate OnFrameMove = null;
    public event EmptyEventHandler DeviceResetting = null;
    public event GraphicsDeviceDelegate DeviceReset = null;
    #endregion

    public XNAWinForm() {
      InitializeComponent();

      this.panelViewport_BackColorChanged(null, EventArgs.Empty);
    }

    #region XNA methods
    protected override void OnLoad(EventArgs e) {
      base.OnLoad(e);

      CreateGraphicsDevice();

      ResetGraphicsDevice();
    }
    private void CreateGraphicsDevice() {
      // Create Presentation Parameters
      PresentationParameters pp = new PresentationParameters();
      //TODO: Fix This
      // pp.BackBufferCount = 1;
      pp.IsFullScreen = false;
      //pp.SwapEffect = SwapEffect.Discard;
      pp.BackBufferWidth = panelViewport.Width;
      pp.BackBufferHeight = panelViewport.Height;
      //pp.AutoDepthStencilFormat = DepthFormat.Depth24Stencil8;
      //pp.EnableAutoDepthStencil = true;
      pp.PresentationInterval = PresentInterval.Default;
      //pp.BackBufferFormat = SurfaceFormat.Unknown;
      //pp.MultiSampleType = MultiSampleType.None;
      pp.DeviceWindowHandle = this.panelViewport.Handle;
      // Create device

      mDevice = new GraphicsDevice(GraphicsAdapter.DefaultAdapter,
          GraphicsProfile.HiDef,
          pp);
    }
    private void ResetGraphicsDevice() {
      // Avoid entering until panelViewport is setup and device created
      if (mDevice == null || panelViewport.Width == 0 || panelViewport.Height == 0)
        return;

      if (this.DeviceResetting != null)
        this.DeviceResetting();

      // Reset device
      mDevice.PresentationParameters.BackBufferWidth = panelViewport.Width;
      mDevice.PresentationParameters.BackBufferHeight = panelViewport.Height;
      mDevice.Reset();

      if (this.DeviceReset != null)
        this.DeviceReset(this.mDevice);
    }
    public void Render() {
      if (this.OnFrameMove != null)
        this.OnFrameMove(this.mDevice);

      mDevice.Clear(this.mBackColor);

      if (this.OnFrameRender != null)
        this.OnFrameRender(this.mDevice);

      mDevice.Present();

    }
    private void OnViewportResize(object sender, EventArgs e) {
      ResetGraphicsDevice();
    }
    private void OnVieweportPaint(object sender, PaintEventArgs e) {
      if (this.mRefreshMode != eRefreshMode.Always)
        this.Render();
    }
    private void panelViewport_BackColorChanged(object sender, EventArgs e) {
      this.mBackColor = new Microsoft.Xna.Framework.Color(panelViewport.BackColor.R, panelViewport.BackColor.G, panelViewport.BackColor.B);
    }
    #endregion
  }
}