using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_upform
{
    public partial class Change_password : Form
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
        public Change_password()
        {
            InitializeComponent();
        }
        private void Change_password_Load(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width,
        button1.Height, 12, 12));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
        panel1.Height, 12, 12));
        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // The control will allow no more than 14 characters.
            textBox1_changepass.MaxLength = 24;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // The control will allow no more than 14 characters.
            textBox2_confirmpass.MaxLength = 24;
        }
        private string userEmail;
        public void SetEmail(string email)
        {
            userEmail = email;
        }

        Modify modify = new Modify();   
        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1_changepass.Text;
            string confirmPassword = textBox2_confirmpass.Text;
            if (confirmPassword != password)
            {
                label2_changepass.Text = "Your password is not correct are";
                label2_changepass.Visible = true;
                label2_changepass.BackColor = Color.Transparent;
                return;
            }
            try
            {
                string hashedPassword = GetHash(password);
                string query = "UPDATE Users SET Password = '"+hashedPassword+"'  WHERE Email = '"+userEmail+"'";
                modify.Command(query);
                password_updated password_Updated = new password_updated();
                password_Updated.Show();
                this.Hide();
            }
            catch
            {

            }
        }
        private string GetHash(string rawData)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert string to a byte array and compute hash.
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                // Create a new StringBuilder to collect the bytes
                // and create a string.
                StringBuilder Builder = new StringBuilder();

                // Loop through each byte of the hashed data
                // and format each one as a hexadecimal string.
                for (int i = 0; i < bytes.Length; i++)
                {
                    Builder.Append(bytes[i].ToString("x2"));
                }
                return Builder.ToString();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
