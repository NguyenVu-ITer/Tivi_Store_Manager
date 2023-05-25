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
    public class Supplier_BLL
    {
        public DataTable Get_Supplier(string conditions) => new Supplier_Access().Get_Supplier_DAL(conditions);
        public bool Check_Exists_Supplier(string supcode) => new Supplier_Access().Check_Exists_Supplier_DAL(supcode);
        public DataTable GetList_Supplier() => new Supplier_Access().GetList_Suppliert_DAL();
        public void Insert_Supplier(Supplier sup) => new Supplier_Access().Insert_Supplier_DAL(sup);
        public void Update_Supplier(Supplier sup) => new Supplier_Access().Update_Supplier_DAL(sup);

    }
}
