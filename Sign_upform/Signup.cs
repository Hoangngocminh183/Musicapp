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
using System.Security.Cryptography;

namespace Sign_upform
{
    public partial class Signup : Form
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
        public Signup()
        {
            InitializeComponent();
            this.Load += Signup_Load;
        }
        private void Signup_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
           panel1.Height, 12, 12)); // bo tròn khung login(panel)
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width,
           button1.Height, 15, 15));
            invalid_pass.Visible = false;
          
        }


        private void textBox2_TextChanged(object sender, EventArgs e)//điền chữ trong khung pass
        {
           
             // The password character is an asterisk.
            textBox2.PasswordChar = '*';
            // Kiểm tra điều kiện tối thiểu là 8 ký tự và hiển thị invalid_pass nếu không đạt
            if (textBox2.Text.Length < 8 || textBox2.Text.Length > 24)
            {
                invalid_pass.Visible = true;
            }
            else
            {
                invalid_pass.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {
            // header sign-up
        }

        private void label_email_Click(object sender, EventArgs e)
        {
            //tựa đề email
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //khung hình chữ email
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //box điền text email
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //label pass
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // khung pass
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //hình i accept term_condition
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            string confirm_password = textBox3.Text;
            if (modify.User("SELECT * FROM Users WHERE Email = '" + email + "' ").Count != 0 || confirm_password != password)
            {
                invalid_pass.Visible=true;
                return;
            }
            try
            {
                //Hash
                string hashedPassword = GetHash(password);

                string query = "INSERT INTO Users (Email, Password) VALUES ('" + email + "', '" + hashedPassword + "')";
                modify.Command(query);
                
            }
            catch
            {
                invalid_pass.Visible = true;
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
                for (int i = 0; i < bytes.Length; i++ )
                {
                    Builder.Append(bytes[i].ToString("x2"));
                }
                return Builder.ToString();
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            //chữ don't have account
        }

    

   
        int flag = 1;
        private void button2_Click(object sender, EventArgs e) // tạo ô tick bằng thêm hiệu ứng chuyển cảnh
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

        private void textBox3_TextChanged(object sender, EventArgs e)//điền chữ trong khung pass
        {
            
                
                // The password character is an asterisk.
                textBox3.PasswordChar = '*';
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Signup_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox4_login_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void invalid_pass_Click(object sender, EventArgs e)
        {

        }
    }
}
