using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideal.Classes.Template_Method
{
    class SB_DB : AbstractDB
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private string _query;
        private List<string> list;
        private int numColum;
        private string tipo;

        public SB_DB(string sql, int n, string t)
        {
            _query = sql;
            numColum = n;
            tipo = t;
        }



        public override void Connect()
        {
            string Path = Environment.CurrentDirectory;
            Path = Path.Remove(Path.Length - 10);
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\documents\\visual studio 2015\\Projects\\Ideal\\Ideal\\IdealDB.mdf;Integrated Security=True";
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Path + "\\IdealDB.mdf;Integrated Security=True";
            con = new SqlConnection(@connectionString);
        }

        public override void Process()
        {
            cmd= new SqlCommand(_query, con);
            con.Open();
            list = new List<string>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (tipo == "insert")
                {
                    list.Add(reader.ToString());
                }

                if (tipo == "select")
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < numColum; i++)
                        {
                            list.Add(reader[i].ToString());
                        }
                    }
                }
            }
        }

        public override void Disconnect()
        {
            con.Close();
        }

        public SqlDataReader Reader
        {
            get { return reader; }
            set { reader = value; }
        }

        public List<string> List
        {
            get { return list; }
            set { list = value; }
        }
    }
}
