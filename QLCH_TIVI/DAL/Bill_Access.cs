using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Bill_Access : DB_Access
    {
        public DataTable Get_Bill_DAL(string conditions) => Get_Object_DAS("TIVI", conditions);
        public DataTable GetList_Bill_DAL() => GetList_Bill_DAS();
        public bool Check_Exists_Bill_DAL(string field, string code) => Check_Exists_DAS("CHI_TIET_HD", field, code);
        public void Insert_Bill_DAL(Bill bill) => Alter_Bill_DAS(bill);
        public void Update_Bill_DAL(Bill bill) => Alter_Bill_DAS(bill, "update");
        public void Delete_Bill_DAL(string code)
        {
            Delete_DAS("CHI_TIET_HD", "MA_HD", code);
            Delete_DAS("HOA_DON", "MA_HD", code);
        }
    }
}
