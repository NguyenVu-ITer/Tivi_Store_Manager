using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Supplier_Access : DB_Access
    {
        public DataTable Get_Supplier_DAL(string conditions) => Get_Object_DAS("NHA_CUNG_CAP", conditions);
        public bool Check_Exists_Supplier_DAL(string supcode) => Check_Exists_DAS("NHA_CUNG_CAP", "MA_NCC", supcode);
        public DataTable GetList_Suppliert_DAL() => Get_Table_DAS("NHA_CUNG_CAP", "TEN_NCC ASC");
        public void Insert_Supplier_DAL(Supplier sup) => Insert_Supplier_DAS(sup);
        public void Update_Supplier_DAL(Supplier sup) => Update_Supplier_DAS(sup);
    }
}
