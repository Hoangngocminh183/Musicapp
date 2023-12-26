namespace Sign_upform.Playlist
{
    partial class Artist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Artist));
            this.ImageArtist = new System.Windows.Forms.PictureBox();
            this.Artistname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageArtist
            // 
            this.ImageArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageArtist.Image = ((System.Drawing.Image)(resources.GetObject("ImageArtist.Image")));
            this.ImageArtist.Location = new System.Drawing.Point(0, 0);
            this.ImageArtist.Margin = new System.Windows.Forms.Padding(4);
            this.ImageArtist.Name = "ImageArtist";
            this.ImageArtist.Size = new System.Drawing.Size(104, 96);
            this.ImageArtist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageArtist.TabIndex = 22;
            this.ImageArtist.TabStop = false;
            this.ImageArtist.Tag = "blocks";
            this.ImageArtist.Click += new System.EventHandler(this.ImageArtist_Click);
            // 
            // Artistname
            // 
            this.Artistname.AutoSize = true;
            this.Artistname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Artistname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Artistname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Artistname.Location = new System.Drawing.Point(21, 100);
            this.Artistname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Artistname.Name = "Artistname";
            this.Artistname.Size = new System.Drawing.Size(55, 20);
            this.Artistname.TabIndex = 52;
            this.Artistname.Tag = "blocks";
            this.Artistname.Text = "Artist";
            this.Artistname.Click += new System.EventHandler(this.Artistname_Click);
            // 
            // Artist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.Artistname);
            this.Controls.Add(this.ImageArtist);
            this.Name = "Artist";
            this.Size = new System.Drawing.Size(142, 126);
            this.Load += new System.EventHandler(this.Artist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageArtist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageArtist;
        private System.Windows.Forms.Label Artistname;
    }
}
