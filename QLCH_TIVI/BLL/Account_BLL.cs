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
    public class Account_BLL
    {
        public Account CheckLogin(string uname, string upass)
            => (uname == string.Empty || upass == string.Empty) ? null : new Account_Access().Checklogin_DAL(uname, upass);
        public DataTable GetList_Account() => new Account_Access().GetList_Account_DAL();
        public bool Check_Exists_Account(string acode) => new Account_Access().Check_Exists_Account_DAL(acode);
        public void Insert_Account(Account acc) => new Account_Access().Insert_Account_DAL(acc);
        public void Update_Account(Account acc) => new Account_Access().Update_Account_DAL(acc);
        public void Delete_Account(string acode) => new Account_Access().Delete_Account_DAL(acode);
    }
}
