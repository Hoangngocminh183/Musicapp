using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_upform
{
    public partial class Signup_Artists : Form
    {
        public Signup_Artists()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            string confirm_password = textBox3.Text;
            if (modify.User("SELECT * FROM Artists WHERE Email = '" + email + "' ").Count != 0)
            {
                label2_signup.Text = "Your email or password is invalid";
                label2_signup.Visible = true;
                label2_signup.BackColor = Color.Transparent;
                return;
            }
            if (confirm_password != password)
            {
                label2_signup.Text = "Your email or password is invalid";
                label2_signup.Visible = true;
                label2_signup.BackColor = Color.Transparent;
                return;
            }
            try
            {
                string hashedPassword = GetHash(password);
                string query = "INSERT INTO Artists VALUES ('" + email + "', '" + hashedPassword + "')";
                modify.Command(query);
            }
            catch
            {
                label2_signup.Text = "Your email or password is invalid";
                label2_signup.Visible = true;
                label2_signup.BackColor = Color.Transparent;
            }
            Form formBackground = new Form();
            try
            {
                using (Notifications uu = new Notifications())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .5d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;

                    // Center Form2 on the screen
                    uu.StartPosition = FormStartPosition.CenterParent;

                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }//nút sign_up 
        }
        //Hàm hash
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
        int flag = 1;
        private void button2_Click(object sender, EventArgs e)
        {

            flag *= -1;
            if (flag == -1)
            {//liên kết đến kho ảnh trong máy(cần phải tải về trước)
                Bitmap b = new Bitmap(@"D:\Năm 3-UIT\NHẬP MÔN CÔMG NGHỆ PHẦN MỀM\login\CNPM pic\tick_icon.jpg");
                button2.Image = b; // gọi lại biến để xuất ảnh
            }
            else
            {
                Bitmap c = new Bitmap(@"D:\Năm 3-UIT\NHẬP MÔN CÔMG NGHỆ PHẦN MỀM\login\CNPM pic\khung_tick.jpg");
                button2.Image = c;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            textBox2.PasswordChar = '*';
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            // The password character is an asterisk.
            textBox3.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Artists login = new Login_Artists();
            login.Show();
            this.Hide();
        }
    }
   
}
