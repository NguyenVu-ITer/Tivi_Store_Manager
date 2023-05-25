using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Supplier
    {
        private string sup_code;
        private string sup_name;
        private string sup_phone;
        private string sup_adress;

        public Supplier(string sup_code = "", string sup_name = "", string sup_phone = "", string sup_adress = "")
        {
            this.Sup_code = sup_code;
            this.Sup_name = sup_name;
            this.Sup_phone = sup_phone;
            this.Sup_adress = sup_adress;
        }

        public string Sup_code { get => sup_code; set => sup_code = value; }
        public string Sup_name { get => sup_name; set => sup_name = value; }
        public string Sup_phone { get => sup_phone; set => sup_phone = value; }
        public string Sup_adress { get => sup_adress; set => sup_adress = value; }
    }
}
