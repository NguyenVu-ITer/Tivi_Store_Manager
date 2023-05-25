using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        private string pro_code;
        private string pro_name;
        private string pro_type;
        private int pro_yearDebut;
        private string pro_guarantee;
        private string pro_size;
        private float pro_weight;
        private string pro_display;
        private int pro_price;
        private string pro_origin;
        private string pro_suppcode;
        private int pro_inventory;

        public string Pro_code { get => pro_code; set => pro_code = value; }
        public string Pro_name { get => pro_name; set => pro_name = value; }
        public string Pro_type { get => pro_type; set => pro_type = value; }
        public int Pro_yearDebut { get => pro_yearDebut; set => pro_yearDebut = value; }
        public string Pro_guarantee { get => pro_guarantee; set => pro_guarantee = value; }
        public string Pro_size { get => pro_size; set => pro_size = value; }
        public float Pro_weight { get => pro_weight; set => pro_weight = value; }
        public string Pro_display { get => pro_display; set => pro_display = value; }
        public int Pro_price { get => pro_price; set => pro_price = value; }
        public string Pro_origin { get => pro_origin; set => pro_origin = value; }
        public string Pro_suppcode { get => pro_suppcode; set => pro_suppcode = value; }
        public int Pro_inventory { get => pro_inventory; set => pro_inventory = value; }

        public Product(string pro_code = "", string pro_name = "", string pro_type = "", int pro_yearDebut = 0, string pro_guarantee = "", string pro_size = "", float pro_weight = 0, string pro_display = "", int pro_price = 0, string pro_origin = "", string pro_suppcode = "", int pro_inventory = 0)
        {
            this.Pro_code = pro_code;
            this.Pro_name = pro_name;
            this.Pro_type = pro_type;
            this.Pro_yearDebut = pro_yearDebut;
            this.Pro_guarantee = pro_guarantee;
            this.Pro_size = pro_size;
            this.Pro_weight = pro_weight;
            this.Pro_display = pro_display;
            this.Pro_price = pro_price;
            this.Pro_origin = pro_origin;
            this.Pro_suppcode = pro_suppcode;
            this.Pro_inventory = pro_inventory;
        }
    }
}
