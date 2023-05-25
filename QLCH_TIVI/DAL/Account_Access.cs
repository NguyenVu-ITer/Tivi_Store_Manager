using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Account_Access : DB_Access
    {
        public Account Checklogin_DAL(string uname, string upass) => Checklogin_DAS(uname, upass);
        public DataTable Get_Account_DAL(string conditions) => Get_Object_DAS("TAI_KHOAN", conditions);
        public DataTable GetList_Account_DAL() => Get_Table_DAS("TAI_KHOAN", "MK_DN ASC");
        public bool Check_Exists_Account_DAL(string acode) => Check_Exists_DAS("TAI_KHOAN", "MA_TK", acode);
        public void Insert_Account_DAL(Account acc) { Insert_Account_DAS(acc); }
        public void Update_Account_DAL(Account acc) { Update_Account_DAS(acc); }
        public void Delete_Account_DAL(string acode) { Delete_DAS("TAI_KHOAN", "MA_TK", acode); }
    }
}
