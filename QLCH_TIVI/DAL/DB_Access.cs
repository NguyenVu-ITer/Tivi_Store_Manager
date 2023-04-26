using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DB_Connect
    {
        public static SqlConnection Connect()
        {
            return new SqlConnection(@"Data Source=LAPTOP-QIHU78TD;Initial Catalog=QLCH_TIVI;Integrated Security=True");
        }
    }

    public class DB_Access
    {
        public static Account Checklogin_DAS(string uname, string upass)
        {
            Account account = null;

            SqlConnection conn = DB_Connect.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SP_LOGIN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@upass", upass);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    account = new Account(
                        reader.GetString(0).Trim(),
                        reader.GetString(1).Trim(),
                        reader.GetString(2).Trim(),
                        reader.GetString(3).Trim(),
                        reader.GetString(4).Trim()
                    );

                    /** OPTION 2:
                     * 
                     * account = new Account();
                     * 
                     * account.Acc_code = reader.GetString(0);
                     * account.User_name = reader.GetString(1);
                     * account.Password = reader.GetString(2);
                     * account.Staff_code = reader.GetString(3);
                     * account.Position_code = reader.GetString(4);
                     * 
                     */
                }
                reader.Close();
                conn.Close();
            }

            return account;
        }

    }
}
