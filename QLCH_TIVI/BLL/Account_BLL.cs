using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class Account_BLL
    {
        Account_Access acc_acs = new Account_Access();

        public Account CheckLogic(string uname, string upass)
        {
            if (uname == string.Empty || upass == string.Empty)
            {
                return null;
            }

            return acc_acs.Checklogin_DAL(uname, upass);

        }
    }
}
