
namespace RayCastEngine
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.SinglePlayer = new System.Windows.Forms.Button();
      this.Multiplayer = new System.Windows.Forms.Button();
      this.Settings = new System.Windows.Forms.Button();
      this.Credits = new System.Windows.Forms.Button();
      this.MapMaker = new System.Windows.Forms.Button();
      this.Exit = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
      this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBox1.Location = new System.Drawing.Point(684, 254);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(165, 174);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // SinglePlayer
      // 
      this.SinglePlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.SinglePlayer.Location = new System.Drawing.Point(12, 12);
      this.SinglePlayer.Name = "SinglePlayer";
      this.SinglePlayer.Size = new System.Drawing.Size(300, 100);
      this.SinglePlayer.TabIndex = 1;
      this.SinglePlayer.Text = "SinglePlayer";
      this.SinglePlayer.UseVisualStyleBackColor = false;
      // 
      // Multiplayer
      // 
      this.Multiplayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Multiplayer.Location = new System.Drawing.Point(318, 12);
      this.Multiplayer.Name = "Multiplayer";
      this.Multiplayer.Size = new System.Drawing.Size(300, 100);
      this.Multiplayer.TabIndex = 2;
      this.Multiplayer.Text = "Multiplayer";
      this.Multiplayer.UseVisualStyleBackColor = false;
      // 
      // Settings
      // 
      this.Settings.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Settings.Location = new System.Drawing.Point(12, 317);
      this.Settings.Name = "Settings";
      this.Settings.Size = new System.Drawing.Size(300, 100);
      this.Settings.TabIndex = 3;
      this.Settings.Text = "Settings";
      this.Settings.UseVisualStyleBackColor = false;
      // 
      // Credits
      // 
      this.Credits.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Credits.Location = new System.Drawing.Point(12, 178);
      this.Credits.Name = "Credits";
      this.Credits.Size = new System.Drawing.Size(300, 100);
      this.Credits.TabIndex = 4;
      this.Credits.Text = "Credits";
      this.Credits.UseVisualStyleBackColor = false;
      // 
      // MapMaker
      // 
      this.MapMaker.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.MapMaker.Location = new System.Drawing.Point(318, 178);
      this.MapMaker.Name = "MapMaker";
      this.MapMaker.Size = new System.Drawing.Size(300, 100);
      this.MapMaker.TabIndex = 5;
      this.MapMaker.Text = "MapMaker";
      this.MapMaker.UseVisualStyleBackColor = false;
      // 
      // Exit
      // 
      this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Exit.Location = new System.Drawing.Point(318, 317);
      this.Exit.Name = "Exit";
      this.Exit.Size = new System.Drawing.Size(300, 100);
      this.Exit.TabIndex = 6;
      this.Exit.Text = "Exit";
      this.Exit.UseVisualStyleBackColor = false;
      this.Exit.Click += new System.EventHandler(this.Menu_Exit);
      // 
      // Menu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoSize = true;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(848, 429);
      this.Controls.Add(this.Exit);
      this.Controls.Add(this.MapMaker);
      this.Controls.Add(this.Credits);
      this.Controls.Add(this.Settings);
      this.Controls.Add(this.Multiplayer);
      this.Controls.Add(this.SinglePlayer);
      this.Controls.Add(this.pictureBox1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Menu";
      this.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.Text = "Form1";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyUp);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button SinglePlayer;
    private System.Windows.Forms.Button Multiplayer;
    private System.Windows.Forms.Button Settings;
    private System.Windows.Forms.Button Credits;
    private System.Windows.Forms.Button MapMaker;
    private System.Windows.Forms.Button Exit;
  }
}

