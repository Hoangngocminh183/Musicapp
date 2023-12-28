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
            invalid_pass.Visible = false;
        }
        private bool IsValidPassword(string password)
        {
            // Add your custom logic to check for special characters in the password
            // For example, you can use regular expressions or any other method to validate

            // Sample: Allow only letters and digits
            return System.Text.RegularExpressions.Regex.IsMatch(password, @"^[a-zA-Z0-9]+$");
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            // Nút login
            string email = textBox1_login.Text;
            string password = textBox2_login.Text;

            // Check for white spaces in email or password
            if (email.Contains(" ") || password.Contains(" "))
            {
                invalid_pass.Visible = true;
                return;
            }

            // Check for special characters in password
            if (!IsValidPassword(password))
            {
                invalid_pass.Visible = true;
                return;
            }
            if (email.Trim() == "")
            {
                invalid_pass.Visible = true;
            }
            else if (password.Trim() == "")
            {
                invalid_pass.Visible = true;
            }
            else
            {
                string hashedPassword = GetHash(password);
                string query = "SELECT * FROM Artists WHERE Email = '" + email + "' and Password = '" + hashedPassword + "'";
                if (modify.User(query).Count != 0)
                {
                    Homepage_Fan homepage = new Homepage_Fan(); 
                    homepage.Show();
                    this.Close();
                }
                else
                {
                   // invalid_pass.Text = "Your email or password is invalid";
                    invalid_pass.Visible = true;
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
            textBox2_login.MaxLength = 25;
            if (textBox2_login.Text.Length < 8 || textBox2_login.Text.Length > 24)
            {
                invalid_pass.Visible = true;
            }
            else
            {
                invalid_pass.Visible = false;
            }
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

        private void Login_Artists_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
           panel1.Height, 12, 12)); // bo tròn khung login(panel)
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width,
           button1.Height, 15, 15));
            invalid_pass.Visible = false;
        }
    }
}
