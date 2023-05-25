using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Position
    {
        private string pos_code;
        private string pos_name;
        private int pos_level;
        private float pos_scfc;

        public string Pos_code { get => pos_code; set => pos_code = value; }
        public string Pos_name { get => pos_name; set => pos_name = value; }
        public int Pos_level { get => pos_level; set => pos_level = value; }
        public float Pos_scfc { get => pos_scfc; set => pos_scfc = value; }

        public Position(string pos_code = "", string pos_name = "", int pos_level = 0, float pos_scfc = 0)
        {
            this.Pos_code = pos_code;
            this.Pos_name = pos_name;
            this.Pos_level = pos_level;
            this.Pos_scfc = pos_scfc;
        }
    }
}
