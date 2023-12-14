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
    public partial class Change_password_Artists : Form
    {
        public Change_password_Artists()
        {
            InitializeComponent();
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
                label2_changepass.Text = "Your password is not correct";
                label2_changepass.Visible = true;
                label2_changepass.BackColor = Color.Transparent;
                return;
            }
            try
            {
                string hashedPassword = GetHash(password);
                string query = "UPDATE Artists SET Password = '" + hashedPassword + "'  WHERE Email = '" + userEmail + "'";
                modify.Command(query);
                Password_update_Artists password_Update = new Password_update_Artists();
                password_Update.Show();
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
        private void textBox2_confirmpass_TextChanged(object sender, EventArgs e)
        {
            // The control will allow no more than 14 characters.
            textBox2_confirmpass.MaxLength = 24;
        }

        private void textBox1_changepass_TextChanged(object sender, EventArgs e)
        {
            // The control will allow no more than 14 characters.
            textBox1_changepass.MaxLength = 24;
        }
    }
}
