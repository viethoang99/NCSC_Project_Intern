using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ex2
{
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }
        static String generateKey(String str, String key)
        {
            int x = str.Length;

            for (int i = 0; ; i++)
            {
                if (x == i)
                    i = 0;
                if (key.Length == str.Length)
                    break;
                key += (key[i]);
            }
            return key;
        }
        static String cipherText(String str, String key)
        {
            String cipher_text = "";
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 65 && str[i] <= 90) || str[i] == 32)
                {
                    // converting in range 0-25 
                    int x = (str[i] + key[i]) % 26;

                    // convert into alphabets(ASCII)
                    if (str[i] != 32)
                    {
                        x += 'A';
                    }
                    else
                    {
                        x = 32;
                    }
                    cipher_text += (char)(x);
                }
                else
                {
                    MessageBox.Show("Incorrect Format!");
                    cipher_text = "";
                    break;
                }
            }
            return cipher_text;           
        }

        static String originalText(String cipher_text, String key)
        {
            String orig_text = "";

            for (int i = 0; i < cipher_text.Length &&
                                    i < key.Length; i++)
            {
                // converting in range 0-25 
                int x = (cipher_text[i] -
                            key[i] + 26) % 26;

                // convert into alphabets(ASCII)
                if (cipher_text[i] != 32)
                    x += 'A';
                else
                    x = 32;
                orig_text += (char)(x);
            }
            return orig_text;
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(plainText.Text) || String.IsNullOrEmpty(txbKey.Text))
            {
                MessageBox.Show("Do not leave empty space!");
            }  
            else if (plainText.Text.Any(char.IsUpper)==false)
            {
                MessageBox.Show("Incorrect Format");
            }    
            else
            {
                String key = generateKey(plainText.Text, txbKey.Text.ToUpper());
                String cipher_text = cipherText(plainText.Text, key);
                crypText.Text = cipher_text;
                String originText = originalText(cipher_text, key);
                txbUnCryp.Text = originText;
            }
        }
    }
}
