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
    public partial class Login_Artists : Form
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
        public Login_Artists()
        {
            InitializeComponent();
            textBox1.Visible = false;
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            // Nút login
            string email = textBox1_login.Text;
            string password = textBox2_login.Text;

            if (email.Trim() == "")
            {
                MessageBox.Show("Please enter the email");
            }
            else if (password.Trim() == "")
            {
                MessageBox.Show("Please enter the password");
            }
            else
            {
                string hashedPassword = GetHash(password);
                string query = "SELECT * FROM Artists WHERE Email = '" + email + "' and Password = '" + hashedPassword + "'";
                if (modify.User(query).Count != 0)
                {
                    MessageBox.Show("Login successfully", "notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    textBox1.Text = "Your email or password is invalid";
                    textBox1.Visible = true;
                }
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
        private void textBox2_login_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            textBox2_login.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox2_login.MaxLength = 24;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Forgotpass_Artistscs forgotpass_Artistscs = new Forgotpass_Artistscs();
            forgotpass_Artistscs.Show();
            this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Signup_Artists signup = new Signup_Artists();
            signup.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
