using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Account_Access : DB_Access
    {
        public Account Checklogin_DAL(string uname, string upass)
        {
            return Checklogin_DAS(uname, upass); 
        }
    }
}
