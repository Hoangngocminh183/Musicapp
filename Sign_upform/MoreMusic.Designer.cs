namespace Sign_upform
{
    partial class MoreMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreMusic));
            this.Home = new System.Windows.Forms.Label();
            this.SearchSong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.InspiroMix = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.NextPage1 = new System.Windows.Forms.PictureBox();
            this.PreviousPage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutMoreMusic = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nowplayingControl1 = new Sign_upform.Playmusic.NowplayingControl();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspiroMix)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousPage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(47, 102);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(49, 17);
            this.Home.TabIndex = 5;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // SearchSong
            // 
            this.SearchSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(81)))), ((int)(((byte)(136)))));
            this.SearchSong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(186)))), ((int)(((byte)(208)))));
            this.SearchSong.Location = new System.Drawing.Point(128, 36);
            this.SearchSong.Margin = new System.Windows.Forms.Padding(4);
            this.SearchSong.Name = "SearchSong";
            this.SearchSong.Size = new System.Drawing.Size(451, 19);
            this.SearchSong.TabIndex = 1;
            this.SearchSong.TextChanged += new System.EventHandler(this.SearchSong_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(19)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.InspiroMix);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 636);
            this.panel1.TabIndex = 144;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 101);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 25);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // InspiroMix
            // 
            this.InspiroMix.BackColor = System.Drawing.Color.Transparent;
            this.InspiroMix.Image = ((System.Drawing.Image)(resources.GetObject("InspiroMix.Image")));
            this.InspiroMix.Location = new System.Drawing.Point(24, 22);
            this.InspiroMix.Margin = new System.Windows.Forms.Padding(4);
            this.InspiroMix.Name = "InspiroMix";
            this.InspiroMix.Size = new System.Drawing.Size(112, 25);
            this.InspiroMix.TabIndex = 1;
            this.InspiroMix.TabStop = false;
            this.InspiroMix.Click += new System.EventHandler(this.InspiroMix_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 32);
            this.label3.TabIndex = 127;
            this.label3.Tag = "blocks";
            this.label3.Text = "Song List";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.panel3.Controls.Add(this.pictureBox12);
            this.panel3.Controls.Add(this.pictureBox16);
            this.panel3.Controls.Add(this.pictureBox30);
            this.panel3.Controls.Add(this.NextPage1);
            this.panel3.Controls.Add(this.PreviousPage);
            this.panel3.Controls.Add(this.SearchSong);
            this.panel3.Controls.Add(this.guna2TextBox1);
            this.panel3.Location = new System.Drawing.Point(211, -4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 92);
            this.panel3.TabIndex = 145;
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.pictureBox30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
            this.pictureBox30.Location = new System.Drawing.Point(884, 22);
            this.pictureBox30.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(43, 39);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox30.TabIndex = 5;
            this.pictureBox30.TabStop = false;
            // 
            // NextPage1
            // 
            this.NextPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NextPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPage1.Image = ((System.Drawing.Image)(resources.GetObject("NextPage1.Image")));
            this.NextPage1.Location = new System.Drawing.Point(59, 34);
            this.NextPage1.Margin = new System.Windows.Forms.Padding(4);
            this.NextPage1.Name = "NextPage1";
            this.NextPage1.Size = new System.Drawing.Size(21, 20);
            this.NextPage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextPage1.TabIndex = 3;
            this.NextPage1.TabStop = false;
            this.NextPage1.Click += new System.EventHandler(this.NextPage1_Click);
            // 
            // PreviousPage
            // 
            this.PreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("PreviousPage.Image")));
            this.PreviousPage.Location = new System.Drawing.Point(23, 34);
            this.PreviousPage.Margin = new System.Windows.Forms.Padding(4);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Size = new System.Drawing.Size(21, 20);
            this.PreviousPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviousPage.TabIndex = 2;
            this.PreviousPage.TabStop = false;
            this.PreviousPage.Click += new System.EventHandler(this.PreviousPage_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.flowLayoutMoreMusic);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(211, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 553);
            this.panel2.TabIndex = 143;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // flowLayoutMoreMusic
            // 
            this.flowLayoutMoreMusic.AutoScroll = true;
            this.flowLayoutMoreMusic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutMoreMusic.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutMoreMusic.Location = new System.Drawing.Point(23, 85);
            this.flowLayoutMoreMusic.Name = "flowLayoutMoreMusic";
            this.flowLayoutMoreMusic.Size = new System.Drawing.Size(904, 1868);
            this.flowLayoutMoreMusic.TabIndex = 137;
            this.flowLayoutMoreMusic.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutMoreMusic_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 104);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 136;
            // 
            // nowplayingControl1
            // 
            this.nowplayingControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(29)))));
            this.nowplayingControl1.Location = new System.Drawing.Point(0, 629);
            this.nowplayingControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nowplayingControl1.Name = "nowplayingControl1";
            this.nowplayingControl1.Size = new System.Drawing.Size(1171, 90);
            this.nowplayingControl1.TabIndex = 147;
            this.nowplayingControl1.Load += new System.EventHandler(this.nowplayingControl1_Load);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 7;
            this.guna2TextBox1.BorderThickness = 0;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "        Let\'s search your tune...";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(81)))), ((int)(((byte)(136)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(186)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(89, 22);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 33;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(732, 41);
            this.guna2TextBox1.TabIndex = 163;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(96, 34);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(24, 22);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 165;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(81)))), ((int)(((byte)(136)))));
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(833, 22);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(43, 39);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 166;
            this.pictureBox12.TabStop = false;
            // 
            // MoreMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nowplayingControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoreMusic";
            this.Text = "MusicList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspiroMix)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousPage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox PreviousPage;
        private System.Windows.Forms.TextBox SearchSong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox InspiroMix;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Playmusic.NowplayingControl nowplayingControl1;
        private System.Windows.Forms.PictureBox NextPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMoreMusic;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}