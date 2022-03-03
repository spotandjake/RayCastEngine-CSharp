namespace RayCastEngine.Views {
  partial class Game {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
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
      this.SuspendLayout();
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
      this.DataView.TabIndex = 0;
      // 
      // Game
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1241, 617);
      this.Controls.Add(this.DataView);
      this.DoubleBuffered = true;
      this.Name = "Game";
      this.Text = "Game";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
      //this.Load += new System.EventHandler(this.Game_Load);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_onPaint);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
      this.Resize += new System.EventHandler(this.Game_Resize);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label DataView;
  }
}