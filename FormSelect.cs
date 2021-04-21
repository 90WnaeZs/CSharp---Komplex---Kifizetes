using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozo
{
    public partial class FormSelect : Form
    {
        public FormSelect()
        {
            InitializeComponent();
        }

        private void btn_rogz_Click(object sender, EventArgs e)
        {
            Rogzit r = new Rogzit();
            r.Show();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            Listazas l = new Listazas();
            l.Show();
        }
    }
}
