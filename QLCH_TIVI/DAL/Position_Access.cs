using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Position_Access : DB_Access
    {
        public DataTable Get_Position_DAL(string conditions) => Get_Object_DAS("CHUC_VU", conditions);
        public DataTable GetList_Position_DAL() => Get_Table_DAS("CHUC_VU", "CAP_DO ASC");
        public bool Check_Exists_Position_DAL(string pcode) => Check_Exists_DAS("CHUC_VU", "MA_CV", pcode);
        public void Insert_Position_DAL(Position pos) => Insert_Position_DAS(pos);
        public void Update_Position_DAL(Position pos) => Update_Position_DAS(pos);
        public void Delete_Position_DAL(string pcode) => Delete_DAS("CHUC_VU", "MA_CV", pcode);
    }
}
