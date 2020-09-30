using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ex2
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            txb16.Text = txb16.Text.ToUpper();
            if (String.IsNullOrEmpty(txb16.Text) == true)
            {
                MessageBox.Show("Do not leave space here!");
            }
            else if (Regex.IsMatch(txb16.Text, @"^[0-9A-F]+$")==true)
            {
                txb2.Text = Convert.ToString(Convert.ToInt32(txb16.Text, 16), 2);
                txb8.Text = Convert.ToString(Convert.ToInt32(txb16.Text, 16), 8);
                txb10.Text = Convert.ToString(Convert.ToInt32(txb16.Text, 16), 10);
            }
            else
            {
                MessageBox.Show("Plaint Text is not a correct form!");
            }    
        }
    }
}
