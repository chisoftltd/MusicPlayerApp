namespace MusicPlayerApp
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.palMusicPlayer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMusicPlayer = new System.Windows.Forms.Label();
            this.btnMusicPlayer = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.ltvMusicPlayer = new System.Windows.Forms.ListBox();
            this.palMusicPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // palMusicPlayer
            // 
            this.palMusicPlayer.BackColor = System.Drawing.Color.SpringGreen;
            this.palMusicPlayer.Controls.Add(this.pictureBox1);
            this.palMusicPlayer.Controls.Add(this.lblMusicPlayer);
            this.palMusicPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.palMusicPlayer.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palMusicPlayer.Location = new System.Drawing.Point(0, 0);
            this.palMusicPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.palMusicPlayer.Name = "palMusicPlayer";
            this.palMusicPlayer.Size = new System.Drawing.Size(1068, 28);
            this.palMusicPlayer.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicPlayerApp.Properties.Resources.icons8_delete_48;
            this.pictureBox1.Location = new System.Drawing.Point(1029, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblMusicPlayer
            // 
            this.lblMusicPlayer.AutoSize = true;
            this.lblMusicPlayer.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicPlayer.Location = new System.Drawing.Point(3, 5);
            this.lblMusicPlayer.Name = "lblMusicPlayer";
            this.lblMusicPlayer.Size = new System.Drawing.Size(93, 19);
            this.lblMusicPlayer.TabIndex = 0;
            this.lblMusicPlayer.Text = "MusicPlayer";
            // 
            // btnMusicPlayer
            // 
            this.btnMusicPlayer.BackColor = System.Drawing.Color.Red;
            this.btnMusicPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMusicPlayer.Location = new System.Drawing.Point(850, 471);
            this.btnMusicPlayer.Name = "btnMusicPlayer";
            this.btnMusicPlayer.Size = new System.Drawing.Size(214, 71);
            this.btnMusicPlayer.TabIndex = 2;
            this.btnMusicPlayer.Text = "Select Song";
            this.btnMusicPlayer.UseVisualStyleBackColor = false;
            this.btnMusicPlayer.Click += new System.EventHandler(this.btnMusicPlayer_Click);
            // 
            // axWindowsMediaPlayerMusic
            // 
            this.axWindowsMediaPlayerMusic.Enabled = true;
            this.axWindowsMediaPlayerMusic.Location = new System.Drawing.Point(7, 34);
            this.axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            this.axWindowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMusic.OcxState")));
            this.axWindowsMediaPlayerMusic.Size = new System.Drawing.Size(837, 430);
            this.axWindowsMediaPlayerMusic.TabIndex = 3;
            this.axWindowsMediaPlayerMusic.Enter += new System.EventHandler(this.axWindowsMediaPlayerMusic_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Developed By ChisoftMedia @ 2020";
            // 
            // ltvMusicPlayer
            // 
            this.ltvMusicPlayer.FormattingEnabled = true;
            this.ltvMusicPlayer.ItemHeight = 16;
            this.ltvMusicPlayer.Location = new System.Drawing.Point(851, 36);
            this.ltvMusicPlayer.Name = "ltvMusicPlayer";
            this.ltvMusicPlayer.Size = new System.Drawing.Size(205, 420);
            this.ltvMusicPlayer.TabIndex = 5;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 554);
            this.Controls.Add(this.ltvMusicPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayerMusic);
            this.Controls.Add(this.btnMusicPlayer);
            this.Controls.Add(this.palMusicPlayer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.palMusicPlayer.ResumeLayout(false);
            this.palMusicPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel palMusicPlayer;
        private System.Windows.Forms.Label lblMusicPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMusicPlayer;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ltvMusicPlayer;
    }
}

