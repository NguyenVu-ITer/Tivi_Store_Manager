using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Staff_Access : DB_Access
    {
        public DataTable Get_Staff_DAL(string scode) => Get_Staff_DAS(scode);
        public DataTable GetList_Staff_DAL() => GetList_Staff_DAS();
        public bool Check_Exists_Staff_DAL(string scode) => Check_Exists_DAS("NHAN_VIEN", "MA_NV", scode);
        public void Insert_Staff_DAL(Staff staff) => Insert_Staff_DAS(staff);
        public void Update_Staff_DAL(Staff staff) => Update_Staff_DAS(staff);
        public void Delete_Staff_DAL(string scode) => Delete_DAS("NHAN_VIEN", "MA_NV", scode);
        public void SalaryUp_DAL(string code, int salary) => SalaryUp_DAS(code, salary);
    }
}
