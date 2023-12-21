namespace Sign_upform.Playlist
{
    partial class ControlMussic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlMussic));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.pictureMusic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitle.Location = new System.Drawing.Point(-4, 145);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(46, 20);
            this.labelTitle.TabIndex = 131;
            this.labelTitle.Tag = "blocks";
            this.labelTitle.Text = "Title";
            this.labelTitle.TextChanged += new System.EventHandler(this.labelTitle_TextChanged);
            this.labelTitle.Click += new System.EventHandler(this.TitleMusic_Click);
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.labelArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.labelArtist.Location = new System.Drawing.Point(-3, 165);
            this.labelArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(36, 16);
            this.labelArtist.TabIndex = 132;
            this.labelArtist.Tag = "blocks";
            this.labelArtist.Text = "Artist";
            this.labelArtist.Click += new System.EventHandler(this.Artist_Click);
            // 
            // pictureMusic
            // 
            this.pictureMusic.Image = ((System.Drawing.Image)(resources.GetObject("pictureMusic.Image")));
            this.pictureMusic.Location = new System.Drawing.Point(0, 0);
            this.pictureMusic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureMusic.Name = "pictureMusic";
            this.pictureMusic.Size = new System.Drawing.Size(160, 142);
            this.pictureMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMusic.TabIndex = 0;
            this.pictureMusic.TabStop = false;
            this.pictureMusic.Click += new System.EventHandler(this.pictureMusic_Click);
            // 
            // ControlMussic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureMusic);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ControlMussic";
            this.Size = new System.Drawing.Size(179, 185);
            this.Load += new System.EventHandler(this.ControlMussic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureMusic;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelArtist;
    }
}
