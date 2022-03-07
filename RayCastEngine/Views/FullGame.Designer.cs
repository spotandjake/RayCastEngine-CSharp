namespace RayCastEngine {
  partial class FullGame {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing) {
        if (components != null) components.Dispose();
        if (bufferTexture != null) bufferTexture.Dispose();
        if (screenSprite != null) screenSprite.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.DataView = new System.Windows.Forms.Label();
      this.panelViewport.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelViewport
      // 
      this.panelViewport.BackColor = System.Drawing.Color.SteelBlue;
      this.panelViewport.Controls.Add(this.DataView);
      this.panelViewport.Dock = System.Windows.Forms.DockStyle.None;
      this.panelViewport.Size = new System.Drawing.Size(1109, 590);
      // 
      // DataView
      // 
      this.DataView.AutoSize = true;
      this.DataView.BackColor = System.Drawing.Color.Transparent;
      this.DataView.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DataView.ForeColor = System.Drawing.SystemColors.ControlText;
      this.DataView.Location = new System.Drawing.Point(0, 0);
      this.DataView.Margin = new System.Windows.Forms.Padding(0);
      this.DataView.Name = "DataView";
      this.DataView.Size = new System.Drawing.Size(0, 24);
      this.DataView.TabIndex = 1;
      // 
      // FullGame
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1111, 592);
      this.Name = "FullGame";
      this.Text = "Game";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
      this.Resize += new System.EventHandler(this.Game_Resize);
      this.panelViewport.ResumeLayout(false);
      this.panelViewport.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label DataView;
  }
}

