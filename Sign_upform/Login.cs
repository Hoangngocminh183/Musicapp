using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using Guna.UI2.WinForms.Suite;

namespace Sign_upform
{

    public partial class Login : Form
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


        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
           panel1.Height, 12, 12)); // bo tròn khung login(panel)
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width,
           button1.Height, 15, 15));
            invalid_pass.Visible = false;

        }

   
       
       

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Nút login
            string email = textBox1_login.Text;
            string password = textBox2_login.Text;

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
                string query = "SELECT * FROM Users WHERE Email = '" + email + "' and Password = '" + hashedPassword + "'";
                if (modify.User(query).Count != 0)
                {
                    Homepage_Fan homepagefan = new Homepage_Fan();
                    homepagefan.Show();
                    this.Hide();
                }
                else
                {
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

        private void label6_Click_1(object sender, EventArgs e)
        {
            forgotpass_form forgotpassword = new forgotpass_form(); 
            forgotpassword.Show();
            this.Hide();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

            // The password character is an asterisk.
            textBox2_login.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox2_login.MaxLength = 25;
            // Kiểm tra điều kiện tối thiểu là 8 ký tự và hiển thị invalid_pass nếu không đạt
            if (textBox2_login.Text.Length < 8 || textBox2_login.Text.Length > 24)
            {
                invalid_pass.Visible = true;
            }
            else
            {
                invalid_pass.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
