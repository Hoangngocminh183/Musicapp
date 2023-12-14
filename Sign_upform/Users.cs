using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_upform
{
    internal class Users
    {
        private string Email;
        private string Password;

        public Users(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }

        public string Email1 { get => Email; set => Email = value; }
        public string Password1 { get => Password; set => Password = value; }
    }
}
