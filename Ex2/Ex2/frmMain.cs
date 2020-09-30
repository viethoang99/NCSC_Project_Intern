using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            frm1 frm_a = new frm1();
            frm_a.Show();
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            frm2 frm_b = new frm2();
            frm_b.Show();
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            frm3 frm_c = new frm3();
            frm_c.Show();
        }
    }
}
