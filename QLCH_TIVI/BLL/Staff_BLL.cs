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
    public class Staff_BLL
    {

        public DataTable Get_Staff(string code) => new Staff_Access().Get_Staff_DAL(code);
        public DataTable GetList_Staff() => new Staff_Access().GetList_Staff_DAL();
        public bool Check_Exists_Staff(string code) => new Staff_Access().Check_Exists_Staff_DAL(code);
        public void Insert_Staff(Staff staff) => new Staff_Access().Insert_Staff_DAL(staff);
        public void Update_Staff(Staff staff) => new Staff_Access().Update_Staff_DAL(staff);
        public void Delete_Staff(string code) => new Staff_Access().Delete_Staff_DAL(code);
        public void SalaryUp(string code, int salary) => new Staff_Access().SalaryUp_DAL(code, salary);
    }
}
