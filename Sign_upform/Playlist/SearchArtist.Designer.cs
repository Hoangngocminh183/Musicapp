namespace Sign_upform.Playlist
{
    partial class SearchArtist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchArtist));
            this.follow = new Guna.UI2.WinForms.Guna2Button();
            this.Follwercount = new System.Windows.Forms.Label();
            this.pictureArtist = new System.Windows.Forms.PictureBox();
            this.Artistname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // follow
            // 
            this.follow.BackColor = System.Drawing.Color.Transparent;
            this.follow.BorderColor = System.Drawing.Color.White;
            this.follow.BorderRadius = 4;
            this.follow.BorderThickness = 1;
            this.follow.CheckedState.Parent = this.follow;
            this.follow.CustomImages.Parent = this.follow;
            this.follow.FillColor = System.Drawing.Color.Transparent;
            this.follow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.follow.ForeColor = System.Drawing.Color.White;
            this.follow.HoverState.Parent = this.follow;
            this.follow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.follow.Location = new System.Drawing.Point(141, 89);
            this.follow.Margin = new System.Windows.Forms.Padding(4);
            this.follow.Name = "follow";
            this.follow.ShadowDecoration.Parent = this.follow;
            this.follow.Size = new System.Drawing.Size(91, 31);
            this.follow.TabIndex = 169;
            this.follow.Text = "Follow";
            this.follow.Click += new System.EventHandler(this.follow_Click);
            // 
            // Follwercount
            // 
            this.Follwercount.BackColor = System.Drawing.Color.Transparent;
            this.Follwercount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Follwercount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Follwercount.ForeColor = System.Drawing.Color.White;
            this.Follwercount.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Follwercount.Location = new System.Drawing.Point(137, 52);
            this.Follwercount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Follwercount.Name = "Follwercount";
            this.Follwercount.Size = new System.Drawing.Size(159, 21);
            this.Follwercount.TabIndex = 167;
            this.Follwercount.Tag = "blocks";
            this.Follwercount.Text = "210.895 followers";
            this.Follwercount.Click += new System.EventHandler(this.Follwercount_Click);
            // 
            // pictureArtist
            // 
            this.pictureArtist.BackColor = System.Drawing.Color.Transparent;
            this.pictureArtist.Image = ((System.Drawing.Image)(resources.GetObject("pictureArtist.Image")));
            this.pictureArtist.Location = new System.Drawing.Point(0, 4);
            this.pictureArtist.Margin = new System.Windows.Forms.Padding(4);
            this.pictureArtist.Name = "pictureArtist";
            this.pictureArtist.Size = new System.Drawing.Size(126, 125);
            this.pictureArtist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureArtist.TabIndex = 166;
            this.pictureArtist.TabStop = false;
            this.pictureArtist.Click += new System.EventHandler(this.pictureArtist_Click);
            // 
            // Artistname
            // 
            this.Artistname.AutoSize = true;
            this.Artistname.BackColor = System.Drawing.Color.Transparent;
            this.Artistname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Artistname.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Artistname.ForeColor = System.Drawing.Color.White;
            this.Artistname.Location = new System.Drawing.Point(134, 4);
            this.Artistname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Artistname.Name = "Artistname";
            this.Artistname.Size = new System.Drawing.Size(98, 38);
            this.Artistname.TabIndex = 170;
            this.Artistname.Tag = "blocks";
            this.Artistname.Text = "Artist";
            this.Artistname.Click += new System.EventHandler(this.labelArtist_Click);
            // 
            // SearchArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Artistname);
            this.Controls.Add(this.follow);
            this.Controls.Add(this.Follwercount);
            this.Controls.Add(this.pictureArtist);
            this.Name = "SearchArtist";
            this.Size = new System.Drawing.Size(463, 146);
            this.Load += new System.EventHandler(this.SearchArtist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureArtist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button follow;
        private System.Windows.Forms.Label Follwercount;
        private System.Windows.Forms.PictureBox pictureArtist;
        private System.Windows.Forms.Label Artistname;
    }
}
