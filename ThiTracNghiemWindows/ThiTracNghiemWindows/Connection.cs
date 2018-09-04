using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ThiTracNghiemWindows
{
    public class Connection
    {
        string server, database, id, pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Database
        {
            get { return database; }
            set { database = value; }
        }

        public string Server
        {
            get { return server; }
            set { server = value; }
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        public int check_connec()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return 0;
            }
            catch
            {
                return 1;
            }
        }

    }
}
