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
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelViewport
      // 
      this.panelViewport.BackColor = System.Drawing.Color.SteelBlue;
      this.panelViewport.Location = new System.Drawing.Point(0, 30);
      this.panelViewport.Size = new System.Drawing.Size(419, 372);
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(419, 30);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(181, 372);
      this.panel1.TabIndex = 3;
      // 
      // FullGame
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(600, 402);
      this.Controls.Add(this.panel1);
      this.Name = "Game";
      this.Text = "Game";
      this.Controls.SetChildIndex(this.panel1, 0);
      this.Controls.SetChildIndex(this.panelViewport, 0);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
  }
}

