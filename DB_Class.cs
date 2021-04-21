using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace Dolgozo
{
    class DB_Class
    {
        public MySqlConnection conn;

        public void Connection()
        {
            MySqlConnectionStringBuilder conn_str = new MySqlConnectionStringBuilder();
            conn_str.Server = "localhost";
            conn_str.Database = "dolgozo";
            conn_str.UserID = "root";
            conn_str.Password = "";

            conn = new MySqlConnection(conn_str.ConnectionString);

            conn.Open();
        }

        public void connection_check(MySqlConnection con)
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void combo_Dolgozó_Feltöltés(MySqlConnection con,ComboBox cmb_dolgozo)
        {
            connection_check(con);

            string QUERY_SELECT_dolgozó = "SELECT nev FROM torzs";

            using (MySqlCommand CMD_SELECT_dolgozó=new MySqlCommand(QUERY_SELECT_dolgozó,con))
            {
                using (MySqlDataReader READER_SELECT_dolgozó=CMD_SELECT_dolgozó.ExecuteReader())
                {
                    while (READER_SELECT_dolgozó.Read())
                    {
                        cmb_dolgozo.Items.Add(READER_SELECT_dolgozó.GetString("nev"));
                    }
                }
            }
        }

        public string dolgozoID(MySqlConnection con, ComboBox cmb_dolgozo)
        {
            connection_check(con);
            string dolgID = "";

            string QUERY_SELECT_dolgozoID = "SELECT id FROM torzs WHERE nev=@nev";
            using (MySqlCommand CMD_SELECT_dolgozoID = new MySqlCommand(QUERY_SELECT_dolgozoID, con))
            {
                CMD_SELECT_dolgozoID.Parameters.Add("@nev", MySqlDbType.VarChar).Value = cmb_dolgozo.Text.Trim();
                using (MySqlDataReader READER_SELECT_dolgozoID = CMD_SELECT_dolgozoID.ExecuteReader())
                {
                    READER_SELECT_dolgozoID.Read();
                    dolgID = READER_SELECT_dolgozoID.GetString("id");
                }
            }
            return dolgID;

        }
    }
}
