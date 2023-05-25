using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Product_Access : DB_Access
    {
        public DataTable Get_Product_DAL(string conditions) => Get_Object_DAS("TIVI", conditions);
        public DataTable GetList_Product_DAL() => Get_Table_DAS("TIVI", "NAMRAMAT DESC");
        public bool Check_Exists_Product_DAL(string procode) => Check_Exists_DAS("TIVI", "MA_TV", procode);
        public void Insert_Product_DAL(Product product) => Insert_Product_DAS(product);
        public void Update_Product_DAL(Product product) => Update_Product_DAS(product);
        public void Update_Product_Inventory_DAL(string code, int amount) => Update_Product_Inventory_DAS(code, amount);
    }
}
