using System;
using System.Text;
using System.Windows.Forms;

namespace Ex2
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(plainText.Text)==true)
            {
                MessageBox.Show("Fill in plain text");
            }
            else
            {
                byte[] textBytes = Encoding.UTF8.GetBytes(plainText.Text);
                txbEncode.Text = Convert.ToBase64String(textBytes);
                byte[] base64EncodedBytes = Convert.FromBase64String(txbEncode.Text);
                txbDecode.Text = Encoding.UTF8.GetString(base64EncodedBytes);
            }
        }
    }
}
