using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class Bill_BLL
    {
        public DataTable GetList_Bill() => new Bill_Access().GetList_Bill_DAL();
        public bool Check_Exists_Bill(string filed, string code) => new Bill_Access().Check_Exists_Bill_DAL(filed, code);
        public void Insert_Bill(Bill bill) => new Bill_Access().Insert_Bill_DAL(bill);
        public void Update_Bill(Bill bill) => new Bill_Access().Update_Bill_DAL(bill);
        public void Delete_Bill(string code) => new Bill_Access().Delete_Bill_DAL(code);
    }
}
