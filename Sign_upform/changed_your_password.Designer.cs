namespace Sign_upform
{
    partial class changed_your_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changed_your_password));
            this.label2_change = new System.Windows.Forms.Label();
            this.label1_change = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2_change
            // 
            this.label2_change.AutoSize = true;
            this.label2_change.BackColor = System.Drawing.Color.Transparent;
            this.label2_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_change.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2_change.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2_change.Location = new System.Drawing.Point(304, 81);
            this.label2_change.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2_change.Name = "label2_change";
            this.label2_change.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2_change.Size = new System.Drawing.Size(467, 40);
            this.label2_change.TabIndex = 12;
            this.label2_change.Text = "Your password reset request has been acknowledged. \r\n                        Plea" +
    "se check your email. ";
            this.label2_change.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2_change.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1_change
            // 
            this.label1_change.AutoSize = true;
            this.label1_change.BackColor = System.Drawing.Color.Transparent;
            this.label1_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_change.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1_change.Location = new System.Drawing.Point(340, 26);
            this.label1_change.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_change.Name = "label1_change";
            this.label1_change.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1_change.Size = new System.Drawing.Size(407, 39);
            this.label1_change.TabIndex = 11;
            this.label1_change.Text = "Changed your password";
            this.label1_change.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1_change.Click += new System.EventHandler(this.label1_Click);
            // 
            // changed_your_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2_change);
            this.Controls.Add(this.label1_change);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "changed_your_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "changed_your_password";
            this.Load += new System.EventHandler(this.changed_your_password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2_change;
        private System.Windows.Forms.Label label1_change;
    }
}