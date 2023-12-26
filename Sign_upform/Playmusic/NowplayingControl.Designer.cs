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
            this.Next = new System.Windows.Forms.PictureBox();
            this.previous = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Share = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.linkicon = new System.Windows.Forms.PictureBox();
            this.linktext = new Guna.UI2.WinForms.Guna2Button();
            this.zaloicon = new System.Windows.Forms.PictureBox();
            this.zalotext = new Guna.UI2.WinForms.Guna2Button();
            this.face_text = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.heart_active)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfer_images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            this.Share.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaloicon)).BeginInit();
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
            this.heart_active.Click += new System.EventHandler(this.heart_active_Click);
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
            this.pictureBox33.Click += new System.EventHandler(this.pictureBox33_Click);
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
            // Share
            // 
            this.Share.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.Share.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.Share.BorderRadius = 4;
            this.Share.BorderThickness = 1;
            this.Share.Controls.Add(this.pictureBox5);
            this.Share.Controls.Add(this.linkicon);
            this.Share.Controls.Add(this.linktext);
            this.Share.Controls.Add(this.zaloicon);
            this.Share.Controls.Add(this.zalotext);
            this.Share.Controls.Add(this.face_text);
            this.Share.Location = new System.Drawing.Point(274, 0);
            this.Share.Margin = new System.Windows.Forms.Padding(4);
            this.Share.Name = "Share";
            this.Share.ShadowDecoration.Parent = this.Share;
            this.Share.Size = new System.Drawing.Size(187, 91);
            this.Share.TabIndex = 179;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(13, 9);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 15);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 157;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "blocks";
            // 
            // linkicon
            // 
            this.linkicon.BackColor = System.Drawing.Color.Transparent;
            this.linkicon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkicon.Image = ((System.Drawing.Image)(resources.GetObject("linkicon.Image")));
            this.linkicon.Location = new System.Drawing.Point(13, 64);
            this.linkicon.Margin = new System.Windows.Forms.Padding(4);
            this.linkicon.Name = "linkicon";
            this.linkicon.Size = new System.Drawing.Size(20, 20);
            this.linkicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.linkicon.TabIndex = 149;
            this.linkicon.TabStop = false;
            this.linkicon.Tag = "blocks";
            // 
            // linktext
            // 
            this.linktext.BorderRadius = 4;
            this.linktext.CheckedState.Parent = this.linktext;
            this.linktext.CustomImages.Parent = this.linktext;
            this.linktext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.linktext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linktext.ForeColor = System.Drawing.Color.White;
            this.linktext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(44)))), ((int)(((byte)(228)))));
            this.linktext.HoverState.Parent = this.linktext;
            this.linktext.Location = new System.Drawing.Point(5, 60);
            this.linktext.Margin = new System.Windows.Forms.Padding(4);
            this.linktext.Name = "linktext";
            this.linktext.ShadowDecoration.Parent = this.linktext;
            this.linktext.Size = new System.Drawing.Size(176, 27);
            this.linktext.TabIndex = 148;
            this.linktext.Text = "     Copy link";
            this.linktext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // zaloicon
            // 
            this.zaloicon.BackColor = System.Drawing.Color.Transparent;
            this.zaloicon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zaloicon.Image = ((System.Drawing.Image)(resources.GetObject("zaloicon.Image")));
            this.zaloicon.Location = new System.Drawing.Point(13, 34);
            this.zaloicon.Margin = new System.Windows.Forms.Padding(4);
            this.zaloicon.Name = "zaloicon";
            this.zaloicon.Size = new System.Drawing.Size(17, 17);
            this.zaloicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.zaloicon.TabIndex = 146;
            this.zaloicon.TabStop = false;
            this.zaloicon.Tag = "blocks";
            // 
            // zalotext
            // 
            this.zalotext.BorderRadius = 4;
            this.zalotext.CheckedState.Parent = this.zalotext;
            this.zalotext.CustomImages.Parent = this.zalotext;
            this.zalotext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.zalotext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.zalotext.ForeColor = System.Drawing.Color.White;
            this.zalotext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(44)))), ((int)(((byte)(228)))));
            this.zalotext.HoverState.Parent = this.zalotext;
            this.zalotext.Location = new System.Drawing.Point(5, 32);
            this.zalotext.Margin = new System.Windows.Forms.Padding(4);
            this.zalotext.Name = "zalotext";
            this.zalotext.ShadowDecoration.Parent = this.zalotext;
            this.zalotext.Size = new System.Drawing.Size(176, 27);
            this.zalotext.TabIndex = 144;
            this.zalotext.Text = "     Zalo";
            this.zalotext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // face_text
            // 
            this.face_text.BorderRadius = 4;
            this.face_text.CheckedState.Parent = this.face_text;
            this.face_text.CustomImages.Parent = this.face_text;
            this.face_text.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.face_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.face_text.ForeColor = System.Drawing.Color.White;
            this.face_text.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(44)))), ((int)(((byte)(228)))));
            this.face_text.HoverState.Parent = this.face_text;
            this.face_text.Location = new System.Drawing.Point(5, 5);
            this.face_text.Margin = new System.Windows.Forms.Padding(4);
            this.face_text.Name = "face_text";
            this.face_text.ShadowDecoration.Parent = this.face_text;
            this.face_text.Size = new System.Drawing.Size(176, 27);
            this.face_text.TabIndex = 142;
            this.face_text.Text = "     Facebook";
            this.face_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NowplayingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.Share);
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
            this.Controls.Add(this.Next);
            this.Controls.Add(this.previous);
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
            ((System.ComponentModel.ISupportInitialize)(this.Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            this.Share.ResumeLayout(false);
            this.Share.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaloicon)).EndInit();
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
        private System.Windows.Forms.PictureBox Next;
        private System.Windows.Forms.PictureBox previous;
        private System.Windows.Forms.PictureBox pictureBox34;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2Panel Share;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox linkicon;
        private Guna.UI2.WinForms.Guna2Button linktext;
        private System.Windows.Forms.PictureBox zaloicon;
        private Guna.UI2.WinForms.Guna2Button zalotext;
        private Guna.UI2.WinForms.Guna2Button face_text;
    }
}
