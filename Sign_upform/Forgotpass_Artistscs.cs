using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_upform
{
    public partial class Forgotpass_Artistscs : Form
    {
        public Forgotpass_Artistscs()
        {
            InitializeComponent();
            delayTimer.Interval = 5000; // 5000 milliseconds (5 seconds)
            delayTimer.Tick += DelayTimer_Tick;
            invalid_pass.Visible = false;
        }

        private void textBox_Forgot_TextChanged(object sender, EventArgs e)
        {

        }
        private Timer delayTimer = new Timer();
        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer when 5 seconds have passed
            delayTimer.Stop();

            // Optionally, add any logic you want to execute after the delay here
        }
        Modify modify = new Modify();
        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBox_Forgot.Text;
            if (modify.User("SELECT * FROM Artists WHERE Email = '" + email + "' ").Count != 0)
            {
                change_your_password_Artists changed_Your_Password = new change_your_password_Artists();
                changed_Your_Password.Show();
                delayTimer.Start(); // Start the timer before showing Change_password
                Change_password_Artists change_Password = new Change_password_Artists();
                change_Password.SetEmail(email);
                await Task.Delay(5000);// Use await to asynchronously wait for the timer
                delayTimer.Stop();  // Stop the timer when 5 seconds have passed
                // Show Change_password and hide changed_your_password
                change_Password.Show();
                changed_Your_Password.Hide();
                this.Hide();
            }
            else
            {
                invalid_pass.Visible = true;
                return;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login_Artists login = new Login_Artists(); 
            login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void invalid_pass_Click(object sender, EventArgs e)
        {

        }
    }
}
