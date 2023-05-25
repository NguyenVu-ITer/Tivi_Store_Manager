using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class Product_BLL
    {
        public DataTable Get_Product(string conditions) => new Product_Access().Get_Product_DAL(conditions);
        public DataTable GetList_Product() => new Product_Access().GetList_Product_DAL();
        public bool Check_Exists_Product(string procode) => new Product_Access().Check_Exists_Product_DAL(procode);
        public void Insert_Product(Product product) => new Product_Access().Insert_Product_DAL(product);
        public void Update_Product(Product product) => new Product_Access().Update_Product_DAL(product);
        public void Update_Inventory(string code, int amount) => new Product_Access().Update_Product_Inventory_DAL(code, amount);
    }
}
