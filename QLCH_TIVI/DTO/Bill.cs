using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        private string bill_detailcode;
        private string bill_code;
        private string bill_datefounded;
        private string bill_staffcode;
        private string bill_customercode;
        private string bill_procode;
        private int bill_amount;
        private int bill_totalprice;

        public Bill(string bill_detailcode = "",
            string bill_code = "",
            string bill_datefounded = "",
            string bill_staffcode = "",
            string bill_customercode = "",
            string bill_procode = "",
            int bill_amount = 0,
            int bill_totalprice = 0)
        {
            this.Bill_detailcode = bill_detailcode;
            this.Bill_code = bill_code;
            this.Bill_datefounded = bill_datefounded;
            this.Bill_staffcode = bill_staffcode;
            this.Bill_customercode = bill_customercode;
            this.Bill_procode = bill_procode;
            this.Bill_amount = bill_amount;
            this.Bill_totalprice = bill_totalprice;
        }

        public string Bill_detailcode { get => bill_detailcode; set => bill_detailcode = value; }
        public string Bill_code { get => bill_code; set => bill_code = value; }
        public string Bill_datefounded { get => bill_datefounded; set => bill_datefounded = value; }
        public string Bill_staffcode { get => bill_staffcode; set => bill_staffcode = value; }
        public string Bill_customercode { get => bill_customercode; set => bill_customercode = value; }
        public string Bill_procode { get => bill_procode; set => bill_procode = value; }
        public int Bill_amount { get => bill_amount; set => bill_amount = value; }
        public int Bill_totalprice { get => bill_totalprice; set => bill_totalprice = value; }
    }
}
