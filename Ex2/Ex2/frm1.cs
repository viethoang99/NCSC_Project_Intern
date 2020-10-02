using System;
using System.CodeDom.Compiler;
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

        public string Hex2Bin(string str, string result)
        {
            int i = 0;
            int n = str.Length;
            while (i<n)
            {
                switch (str[i])
                {
                    case '0':
                        result+="0000";
                        break;
                    case '1':
                        result+="0001";
                        break;
                    case '2':
                        result+="0010";
                        break;
                    case '3':
                        result+="0011";
                        break;
                    case '4':
                        result+="0100";
                        break;
                    case '5':
                        result+="0101";
                        break;
                    case '6':
                        result+="0110";
                        break;
                    case '7':
                        result+="0111";
                        break;
                    case '8':
                        result+="1000";
                        break;
                    case '9':
                        result+="1001";
                        break;
                    case 'A':
                    case 'a':
                        result+="1010";
                        break;
                    case 'B':
                    case 'b':
                        result+="1011";
                        break;
                    case 'C':
                    case 'c':
                        result+="1100";
                        break;
                    case 'D':
                    case 'd':
                        result+="1101";
                        break;
                    case 'E':
                    case 'e':
                        result+="1110";
                        break;
                    case 'F':
                    case 'f':
                        result+="1111";
                        break;
                    default:
                        result+="\nInvalid hexadecimal digit " +str[i];
                        break;
                }
                i++;
            }
            return result;
        }
        public string Hex2Oct(string str,string temp,string result)
        {
            string s = Hex2Bin(str,"");
            int len = s.Length%3;
            for (int i=1;i<=3-len;i++)
            {
                s = '0' + s;
            }
            int n = s.Length;
            for (int j=0;j<n;j++)
            {
                temp += s[j];
                if  (temp.Length==3)
                {
                    if (temp == "000") result += "0";
                    if (temp == "001") result += "1";
                    if (temp == "010") result += "2";
                    if (temp == "011") result += "3";
                    if (temp == "100") result += "4";
                    if (temp == "101") result += "5";
                    if (temp == "110") result += "6";
                    if (temp == "111") result += "7";
                    temp = "";
                }    
            }
            return result.TrimStart('0');
        }
        public string Hex2Dec(string str, UInt64 result)
        {
            char[] table = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
            int n = str.Length;
            for (int i = 0; i < n ; i++)
            {
                for (int j = 0; j < table.Length; j++)
                {
                    if (str[i] == table[j]) result += (UInt64)(j * Math.Pow(16, n - i - 1));
                }
            }
            return result.ToString();
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
                txb2.Text = Hex2Bin(txb16.Text,"");
                txb8.Text = Hex2Oct(txb16.Text, "", "");
                txb10.Text = Hex2Dec(txb16.Text, 0);
            }
            else
            {
                MessageBox.Show("Plaint Text is not a correct form!");
            }    
        }
    }
}
