﻿
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
      this.panel1 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
      this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBox1.Location = new System.Drawing.Point(855, 318);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(206, 218);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // SinglePlayer
      // 
      this.SinglePlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.SinglePlayer.Location = new System.Drawing.Point(-2, 0);
      this.SinglePlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.SinglePlayer.Name = "SinglePlayer";
      this.SinglePlayer.Size = new System.Drawing.Size(375, 125);
      this.SinglePlayer.TabIndex = 1;
      this.SinglePlayer.Text = "SinglePlayer";
      this.SinglePlayer.UseVisualStyleBackColor = false;
      // 
      // Multiplayer
      // 
      this.Multiplayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Multiplayer.Location = new System.Drawing.Point(383, -2);
      this.Multiplayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Multiplayer.Name = "Multiplayer";
      this.Multiplayer.Size = new System.Drawing.Size(375, 125);
      this.Multiplayer.TabIndex = 2;
      this.Multiplayer.Text = "Multiplayer";
      this.Multiplayer.UseVisualStyleBackColor = false;
      // 
      // Settings
      // 
      this.Settings.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Settings.Location = new System.Drawing.Point(-2, 381);
      this.Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Settings.Name = "Settings";
      this.Settings.Size = new System.Drawing.Size(375, 125);
      this.Settings.TabIndex = 3;
      this.Settings.Text = "Settings";
      this.Settings.UseVisualStyleBackColor = false;
      // 
      // Credits
      // 
      this.Credits.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Credits.Location = new System.Drawing.Point(0, 207);
      this.Credits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Credits.Name = "Credits";
      this.Credits.Size = new System.Drawing.Size(375, 125);
      this.Credits.TabIndex = 4;
      this.Credits.Text = "Credits";
      this.Credits.UseVisualStyleBackColor = false;
      // 
      // MapMaker
      // 
      this.MapMaker.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.MapMaker.Location = new System.Drawing.Point(383, 207);
      this.MapMaker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MapMaker.Name = "MapMaker";
      this.MapMaker.Size = new System.Drawing.Size(375, 125);
      this.MapMaker.TabIndex = 5;
      this.MapMaker.Text = "MapMaker";
      this.MapMaker.UseVisualStyleBackColor = false;
      // 
      // Exit
      // 
      this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Exit.Location = new System.Drawing.Point(383, 381);
      this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Exit.Name = "Exit";
      this.Exit.Size = new System.Drawing.Size(375, 125);
      this.Exit.TabIndex = 6;
      this.Exit.Text = "Exit";
      this.Exit.UseVisualStyleBackColor = false;
      this.Exit.Click += new System.EventHandler(this.Menu_Exit);
      // 
      // panel1
      // 
      this.panel1.AutoSize = true;
      this.panel1.BackColor = System.Drawing.Color.Transparent;
      this.panel1.Controls.Add(this.Settings);
      this.panel1.Controls.Add(this.Exit);
      this.panel1.Controls.Add(this.SinglePlayer);
      this.panel1.Controls.Add(this.MapMaker);
      this.panel1.Controls.Add(this.Multiplayer);
      this.panel1.Controls.Add(this.Credits);
      this.panel1.Location = new System.Drawing.Point(15, 15);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(762, 510);
      this.panel1.TabIndex = 7;
      // 
      // Menu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoSize = true;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1060, 536);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Menu";
      this.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.Text = "Form1";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyUp);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button SinglePlayer;
    private System.Windows.Forms.Button Multiplayer;
    private System.Windows.Forms.Button Settings;
    private System.Windows.Forms.Button Credits;
    private System.Windows.Forms.Button MapMaker;
    private System.Windows.Forms.Button Exit;
    private System.Windows.Forms.Panel panel1;
  }
}

