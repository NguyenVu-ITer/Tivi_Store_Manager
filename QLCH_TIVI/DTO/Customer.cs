using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        private string cus_code;
        private string cus_name;
        private string cus_phone;
        private string cus_email;
        private string cus_address;

        public Customer(string cus_code = "", string cus_name = "", string cus_phone = "", string cus_email = "", string cus_address = "")
        {
            this.Cus_code = cus_code;
            this.Cus_name = cus_name;
            this.Cus_phone = cus_phone;
            this.Cus_email = cus_email;
            this.Cus_address = cus_address;
        }

        public string Cus_code { get => cus_code; set => cus_code = value; }
        public string Cus_name { get => cus_name; set => cus_name = value; }
        public string Cus_phone { get => cus_phone; set => cus_phone = value; }
        public string Cus_email { get => cus_email; set => cus_email = value; }
        public string Cus_address { get => cus_address; set => cus_address = value; }
    }
}
