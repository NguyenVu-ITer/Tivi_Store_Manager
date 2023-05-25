using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Customer_BLL
    {
        public DataTable Get_Customer(string conditions) => new Customer_Access().Get_Customer_DAL(conditions);
        public DataTable GetList_Customer() => new Customer_Access().GetList_Customer_DAL();
        public bool Check_Exists_Customer(string code) => new Customer_Access().Check_Exists_Customer_DAL(code);
        public void Insert_Customer(Customer cus) => new Customer_Access().Insert_Cus_DAL(cus);
        public void Update_Customer(Customer cus) => new Customer_Access().Update_Cus_DAL(cus);
        public void Delete_Customer(string pcode) => new Customer_Access().Delete_Cus_DAL(pcode);
    }
}
