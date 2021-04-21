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
    public partial class Rogzit : Form
    {
        DB_Class db;
        public Rogzit()
        {
            InitializeComponent();
            db = new DB_Class();
            db.Connection();
            db.connection_check(db.conn);
            db.combo_Dolgozó_Feltöltés(db.conn, combo_dolgozo);
        }

        private void btn_Rogzit_Click(object sender, EventArgs e)
        {
            try
            {
                if (num_osszeg.Value >= 100000 && num_osszeg.Value <= 150000)
                {
                    db.connection_check(db.conn);

                    string dolgozoID = "";
                    string QUERY_INSERT_kifizetés = "INSERT INTO kifizetes (dolgozoid,osszeg,datum) VALUES(@dolgID,@osszeg,@datum)";

                    using (MySqlCommand CMD_INSERT_kifizetés=new MySqlCommand(QUERY_INSERT_kifizetés, db.conn))
                    {
                        dolgozoID = db.dolgozoID(db.conn,combo_dolgozo);

                        CMD_INSERT_kifizetés.Parameters.Add("@dolgID",MySqlDbType.Int32).Value =Convert.ToInt32(dolgozoID);
                        CMD_INSERT_kifizetés.Parameters.Add("@osszeg", MySqlDbType.Int32).Value = num_osszeg.Value;
                        CMD_INSERT_kifizetés.Parameters.Add("@datum", MySqlDbType.Timestamp).Value = DateTime.Now;

                        if (CMD_INSERT_kifizetés.ExecuteNonQuery()>0)
                        {
                            MessageBox.Show("Sikeres rögzítés!");
                        }
                        else
                        {
                            MessageBox.Show("Sikertelen rögzítés!");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Az összegnek 100.000 és 150.000 között kell lennie!");
                }
                db.conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
