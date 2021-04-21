using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Dolgozo
{
    public partial class Listazas : Form
    {
        DB_Class db;
        public Listazas()
        {
            InitializeComponent();
            db = new DB_Class();
            db.Connection();
            db.combo_Dolgozó_Feltöltés(db.conn,this.combo_dolgozo);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            db.connection_check(db.conn);

            string dolgozoID = "";
            DataTable DT_SELECT_ALL = new DataTable();
            string QUERY_SELECT_kifizetes = "SELECT torzs.nev,kifizetes.osszeg,kifizetes.datum FROM torzs JOIN kifizetes ON torzs.id=kifizetes.dolgozoid WHERE dolgozoid=@dolgID";
            
            using (MySqlCommand CMD_SELECT_kifizetes = new MySqlCommand(QUERY_SELECT_kifizetes, db.conn))
            {
                dolgozoID=db.dolgozoID(db.conn,combo_dolgozo);
                CMD_SELECT_kifizetes.Parameters.Add("@dolgID", MySqlDbType.Int32).Value = Convert.ToInt32(dolgozoID);
                using (MySqlDataReader READER_SELECT_kifizetes=CMD_SELECT_kifizetes.ExecuteReader())
                {
                    DT_SELECT_ALL.Load(READER_SELECT_kifizetes);
                    dataGridView1.DataSource = DT_SELECT_ALL;
                    //listView1.Items.Add("NÉV: "+combo_dolgozo.Text.Trim()+" ÖSSZEG -> "+READER_SELECT_kifizetes.GetString("osszeg")+" DÁTUM: "+READER_SELECT_kifizetes.GetString("datum"));
                    //lbl_atlag
                }
            }
            db.conn.Close();
        }

        private void btn_Átlag_Click(object sender, EventArgs e)
        {
            db.connection_check(db.conn);
            string dolgozoID = "";

            string QUERY_SELECT_atlag = "SELECT AVG(kifizetes.osszeg) AS 'Átlag' FROM kifizetes JOIN torzs ON torzs.id=kifizetes.dolgozoid WHERE dolgozoid=@dolgID";

            using (MySqlCommand CMD_SELECT_atlag = new MySqlCommand(QUERY_SELECT_atlag, db.conn))
            {
                dolgozoID = db.dolgozoID(db.conn, combo_dolgozo);
                CMD_SELECT_atlag.Parameters.Add("@dolgID", MySqlDbType.Int32).Value = Convert.ToInt32(dolgozoID);

                using (MySqlDataReader READER_SELECT_kifizetes = CMD_SELECT_atlag.ExecuteReader())
                {
                    READER_SELECT_kifizetes.Read();
                    lbl_atlag.Text = "Átlag: "+READER_SELECT_kifizetes.GetString("Átlag")+" Ft";
                }
            }
            db.conn.Close();
        }
    }
}
