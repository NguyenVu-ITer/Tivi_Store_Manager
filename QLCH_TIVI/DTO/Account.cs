using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string acc_code;
        private string user_name;
        private string password;
        private string staff_code;
        private int position;

        public string Acc_code { get => acc_code; set => acc_code = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string Password { get => password; set => password = value; }
        public string Staff_code { get => staff_code; set => staff_code = value; }
        public int Position { get => position; set => position = value; }

        public Account(string acc_code = "", string user_name = "", string password = "", string staff_code = "", int position = 0)
        {
            this.Acc_code = acc_code;
            this.User_name = user_name;
            this.Password = password;
            this.Staff_code = staff_code;
            this.Position = position;
        }
    }
}
