namespace Sign_upform.Playmusic
{
    partial class NowplayingControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NowplayingControl));
            this.TitleArtist = new System.Windows.Forms.Label();
            this.TitleMusic = new System.Windows.Forms.Label();
            this.Volume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.labelRealTime = new System.Windows.Forms.Label();
            this.heart_active = new System.Windows.Forms.PictureBox();
            this.transfer_images = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.play_pause = new System.Windows.Forms.PictureBox();
            this.MusicLoop = new System.Windows.Forms.PictureBox();
            this.Next = new System.Windows.Forms.PictureBox();
            this.previous = new System.Windows.Forms.PictureBox();
            this.RandomMusic = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.heart_active)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfer_images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicLoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleArtist
            // 
            this.TitleArtist.AutoSize = true;
            this.TitleArtist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TitleArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TitleArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TitleArtist.Location = new System.Drawing.Point(103, 27);
            this.TitleArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleArtist.Name = "TitleArtist";
            this.TitleArtist.Size = new System.Drawing.Size(0, 16);
            this.TitleArtist.TabIndex = 149;
            this.TitleArtist.Tag = "blocks";
            this.TitleArtist.Click += new System.EventHandler(this.TitleArtist_Click);
            // 
            // TitleMusic
            // 
            this.TitleMusic.AutoSize = true;
            this.TitleMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TitleMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TitleMusic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TitleMusic.Location = new System.Drawing.Point(103, 2);
            this.TitleMusic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleMusic.Name = "TitleMusic";
            this.TitleMusic.Size = new System.Drawing.Size(0, 18);
            this.TitleMusic.TabIndex = 150;
            this.TitleMusic.Tag = "blocks";
            this.TitleMusic.TextChanged += new System.EventHandler(this.TitleMusic_TextChanged);
            this.TitleMusic.Click += new System.EventHandler(this.TitleMusic_Click);
            // 
            // Volume
            // 
            this.Volume.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Volume.HoverState.Parent = this.Volume;
            this.Volume.Location = new System.Drawing.Point(1060, 31);
            this.Volume.Margin = new System.Windows.Forms.Padding(4);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(87, 12);
            this.Volume.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.Volume.TabIndex = 162;
            this.Volume.ThumbColor = System.Drawing.Color.White;
            this.Volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Volume_Scroll);
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(661, 36);
            this.guna2ProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.White;
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.White;
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(309, 4);
            this.guna2ProgressBar1.TabIndex = 154;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar1.Value = 1;
            this.guna2ProgressBar1.ValueChanged += new System.EventHandler(this.guna2ProgressBar1_ValueChanged);
            this.guna2ProgressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2ProgressBar1_MouseDown);
            this.guna2ProgressBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2ProgressBar1_MouseMove);
            this.guna2ProgressBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2ProgressBar1_MouseUp);
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.labelTotalTime.Location = new System.Drawing.Point(973, 30);
            this.labelTotalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(55, 20);
            this.labelTotalTime.TabIndex = 161;
            this.labelTotalTime.Text = "00:00";
            this.labelTotalTime.Click += new System.EventHandler(this.labelTotalTime_Click);
            // 
            // labelRealTime
            // 
            this.labelRealTime.AutoSize = true;
            this.labelRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRealTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRealTime.Location = new System.Drawing.Point(599, 30);
            this.labelRealTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRealTime.Name = "labelRealTime";
            this.labelRealTime.Size = new System.Drawing.Size(55, 20);
            this.labelRealTime.TabIndex = 160;
            this.labelRealTime.Text = "00:00";
            this.labelRealTime.Click += new System.EventHandler(this.labelRealTime_Click);
            // 
            // heart_active
            // 
            this.heart_active.Image = ((System.Drawing.Image)(resources.GetObject("heart_active.Image")));
            this.heart_active.Location = new System.Drawing.Point(205, 31);
            this.heart_active.Margin = new System.Windows.Forms.Padding(4);
            this.heart_active.Name = "heart_active";
            this.heart_active.Size = new System.Drawing.Size(15, 15);
            this.heart_active.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.heart_active.TabIndex = 159;
            this.heart_active.TabStop = false;
            // 
            // transfer_images
            // 
            this.transfer_images.BackColor = System.Drawing.Color.Transparent;
            this.transfer_images.Location = new System.Drawing.Point(11, 2);
            this.transfer_images.Margin = new System.Windows.Forms.Padding(4);
            this.transfer_images.Name = "transfer_images";
            this.transfer_images.Size = new System.Drawing.Size(84, 78);
            this.transfer_images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.transfer_images.TabIndex = 151;
            this.transfer_images.TabStop = false;
            this.transfer_images.Click += new System.EventHandler(this.transfer_images_Click);
            // 
            // pictureBox40
            // 
            this.pictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox40.Image")));
            this.pictureBox40.Location = new System.Drawing.Point(1037, 32);
            this.pictureBox40.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(14, 11);
            this.pictureBox40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox40.TabIndex = 158;
            this.pictureBox40.TabStop = false;
            // 
            // play_pause
            // 
            this.play_pause.Image = ((System.Drawing.Image)(resources.GetObject("play_pause.Image")));
            this.play_pause.Location = new System.Drawing.Point(447, 23);
            this.play_pause.Margin = new System.Windows.Forms.Padding(4);
            this.play_pause.Name = "play_pause";
            this.play_pause.Size = new System.Drawing.Size(31, 30);
            this.play_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.play_pause.TabIndex = 157;
            this.play_pause.TabStop = false;
            this.play_pause.Click += new System.EventHandler(this.play_pause_Click);
            // 
            // MusicLoop
            // 
            this.MusicLoop.Image = ((System.Drawing.Image)(resources.GetObject("MusicLoop.Image")));
            this.MusicLoop.Location = new System.Drawing.Point(544, 32);
            this.MusicLoop.Margin = new System.Windows.Forms.Padding(4);
            this.MusicLoop.Name = "MusicLoop";
            this.MusicLoop.Size = new System.Drawing.Size(16, 15);
            this.MusicLoop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MusicLoop.TabIndex = 156;
            this.MusicLoop.TabStop = false;
            this.MusicLoop.Click += new System.EventHandler(this.loop_Click);
            // 
            // Next
            // 
            this.Next.Image = ((System.Drawing.Image)(resources.GetObject("Next.Image")));
            this.Next.Location = new System.Drawing.Point(504, 32);
            this.Next.Margin = new System.Windows.Forms.Padding(4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(15, 15);
            this.Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Next.TabIndex = 155;
            this.Next.TabStop = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // previous
            // 
            this.previous.Image = ((System.Drawing.Image)(resources.GetObject("previous.Image")));
            this.previous.Location = new System.Drawing.Point(407, 32);
            this.previous.Margin = new System.Windows.Forms.Padding(4);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(15, 15);
            this.previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.previous.TabIndex = 153;
            this.previous.TabStop = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // RandomMusic
            // 
            this.RandomMusic.Image = ((System.Drawing.Image)(resources.GetObject("RandomMusic.Image")));
            this.RandomMusic.Location = new System.Drawing.Point(368, 32);
            this.RandomMusic.Margin = new System.Windows.Forms.Padding(4);
            this.RandomMusic.Name = "RandomMusic";
            this.RandomMusic.Size = new System.Drawing.Size(15, 15);
            this.RandomMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RandomMusic.TabIndex = 148;
            this.RandomMusic.TabStop = false;
            this.RandomMusic.Click += new System.EventHandler(this.RandomMusic_Click);
            // 
            // pictureBox34
            // 
            this.pictureBox34.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox34.Image")));
            this.pictureBox34.Location = new System.Drawing.Point(251, 31);
            this.pictureBox34.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(15, 15);
            this.pictureBox34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox34.TabIndex = 152;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox33.Image")));
            this.pictureBox33.Location = new System.Drawing.Point(228, 31);
            this.pictureBox33.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(15, 15);
            this.pictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox33.TabIndex = 147;
            this.pictureBox33.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // NowplayingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.TitleArtist);
            this.Controls.Add(this.TitleMusic);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.guna2ProgressBar1);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.labelRealTime);
            this.Controls.Add(this.heart_active);
            this.Controls.Add(this.transfer_images);
            this.Controls.Add(this.pictureBox40);
            this.Controls.Add(this.play_pause);
            this.Controls.Add(this.MusicLoop);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.RandomMusic);
            this.Controls.Add(this.pictureBox34);
            this.Controls.Add(this.pictureBox33);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NowplayingControl";
            this.Size = new System.Drawing.Size(1165, 85);
            this.Load += new System.EventHandler(this.NowplayingControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.heart_active)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfer_images)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicLoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleArtist;
        private System.Windows.Forms.Label TitleMusic;
        private Guna.UI2.WinForms.Guna2TrackBar Volume;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Label labelRealTime;
        private System.Windows.Forms.PictureBox heart_active;
        private System.Windows.Forms.PictureBox transfer_images;
        private System.Windows.Forms.PictureBox pictureBox40;
        private System.Windows.Forms.PictureBox play_pause;
        private System.Windows.Forms.PictureBox MusicLoop;
        private System.Windows.Forms.PictureBox Next;
        private System.Windows.Forms.PictureBox previous;
        private System.Windows.Forms.PictureBox RandomMusic;
        private System.Windows.Forms.PictureBox pictureBox34;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
