using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Staff
    {
        private string staff_code;
        private string staff_name;
        private string staff_phone;
        private string staff_email;
        private string staff_poscode;
        private int staff_salary;
        private int staff_poslevel;

        public string Staff_code { get => staff_code; set => staff_code = value; }
        public string Staff_name { get => staff_name; set => staff_name = value; }
        public string Staff_phone { get => staff_phone; set => staff_phone = value; }
        public string Staff_email { get => staff_email; set => staff_email = value; }
        public string Staff_poscode { get => staff_poscode; set => staff_poscode = value; }
        public int Staff_salary { get => staff_salary; set => staff_salary = value; }
        public int Staff_poslevel { get => staff_poslevel; set => staff_poslevel = value; }

        public Staff(string staff_code = "",
            string staff_name = "",
            string staff_phone = "",
            string staff_email = "",
            string staff_poscode = "",
            int staff_salary = 0,
            int staff_poslevel = 0)
        {
            this.Staff_code = staff_code;
            this.Staff_name = staff_name;
            this.Staff_phone = staff_phone;
            this.Staff_email = staff_email;
            this.Staff_poscode = staff_poscode;
            this.Staff_salary = staff_salary;
            this.Staff_poslevel = staff_poslevel;
        }
    }
}
