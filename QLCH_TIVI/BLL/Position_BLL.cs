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
    public class Position_BLL
    {
        public DataTable Get_Position(string conditions) => new Position_Access().Get_Position_DAL(conditions);
        public DataTable GetList_Position() => new Position_Access().GetList_Position_DAL();
        public bool Check_Exists_Position(string pcode) => new Position_Access().Check_Exists_Position_DAL(pcode);
        public void Insert_Position(Position pos) => new Position_Access().Insert_Position_DAL(pos);
        public void Update_Position(Position pos) => new Position_Access().Update_Position_DAL(pos);
        public void Delete_Position(string pcode) => new Position_Access().Delete_Position_DAL(pcode);

    }
}
