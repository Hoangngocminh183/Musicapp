using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_upform
{
    public partial class Notification_Artist : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
          );
        public Notification_Artist()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Homepage_Fan homepagefan = new Homepage_Fan();
            homepagefan.Show();
            this.Hide();
            Signup signup = new Signup();
            signup.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notification_Artist_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
           panel1.Height, 12, 12)); // bo tròn khung congratulation
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width,
          button1.Height, 12, 12));
        }
    }
}
