using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        String str, op = "NULL", res="NULL", opr1 = "NULL", opr2 = "NULL";
        int flag = 0;
        int[] Flag = new int[4] { 0, 0, 0, 0 };
        char[] Remove = "√()".ToCharArray();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Textbox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                Textbox1.Text = " ";
            if (Textbox1.Text == "-")
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "7";
            }
            else if (Textbox1.Text.Equals("0"))
                Textbox1.Text = "7";
            else
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "7";

            }
            flag = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                Textbox1.Text = " ";
            if (Textbox1.Text == "-")
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "9";
            }
            else if (Textbox1.Text.Equals("0"))
                Textbox1.Text = "9";
            else
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "9";

            }
            flag = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                Textbox1.Text = " ";
            if (Textbox1.Text == "-")
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "2";
            }
            else if (Textbox1.Text.Equals("0"))
                Textbox1.Text = "2";
            else
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "2";

            }
            flag = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                Textbox1.Text = " ";
            if (Textbox1.Text == "-")
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "3";
            }
            else if (Textbox1.Text.Equals("0"))
                Textbox1.Text = "3";
            else
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "3";

            }
            flag = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                Textbox1.Text = " ";
            if (Textbox1.Text == "-")
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "1";
            }
            else if (Textbox1.Text.Equals("0"))
                Textbox1.Text = "1";
            else
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "1";

            }
            flag = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                Textbox1.Text = " ";
            if (Textbox1.Text == "-")
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "5";
            }
            else if (Textbox1.Text.Equals("0"))
                Textbox1.Text = "5";
            else
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "5";

            }
            flag = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                Textbox1.Text = " ";
            if (Textbox1.Text == "-")
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "6";
            }
            else if (Textbox1.Text.Equals("0"))
                Textbox1.Text = "6";
            else
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "6";

            }
            flag = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            opr2 = Textbox1.Text;
            if (opr2 == "NULL" || Textbox1.Text == "+" || Textbox1.Text == "-" || Textbox1.Text == "*" || Textbox1.Text == "/" || Textbox1.Text.EndsWith("-)"))
                Textbox1.Text = "Invalid Operation";

            else if (opr2 != "NULL")
            {

                if (op == "+")
                {
                    Flag[1] = Flag[2] = Flag[3] = 0;
                    if (Flag[0] == 0)
                    {
                        Textbox1.Text = (Convert.ToDecimal(opr1) + Convert.ToDecimal(opr2)).ToString();
                        opr1 = opr2;
                        Flag[0] = 1;
                    }
                    else if (Flag[0] == 1)
                    {
                        Textbox1.Text = (Convert.ToDecimal(opr2) + Convert.ToDecimal(opr1)).ToString();
                    }
                }
                else if (op == "-")
                {
                    Flag[0] = Flag[2] = Flag[3] = 0;
                    if (Flag[1] == 0)
                    {
                        Textbox1.Text = (Convert.ToDecimal(opr1) - Convert.ToDecimal(opr2)).ToString();
                        opr1 = opr2;
                        Flag[1] = 1;
                    }
                    else if (Flag[1] == 1)
                    {
                        Textbox1.Text = (Convert.ToDecimal(opr2) - Convert.ToDecimal(opr1)).ToString();

                    }

                }
                else if (op == "*")
                {
                    Flag[0] = Flag[1] = Flag[3] = 0;
                    if (Flag[2] == 0)
                    {
                        Textbox1.Text = (Convert.ToDecimal(opr1) * Convert.ToDecimal(opr2)).ToString();
                        opr1 = opr2;
                        Flag[2] = 1;
                    }
                    else if (Flag[2] == 1)
                    {
                        Textbox1.Text = (Convert.ToDecimal(opr2) * Convert.ToDecimal(opr1)).ToString();

                    }


                }
                else if (op == "/")
                {
                    Flag[0] = Flag[2] = Flag[1] = 0;
                    if (Flag[3] == 0)
                    {
                        if (Convert.ToDecimal(opr2) == 0)
                            Textbox1.Text = "Undefined Result";
                        else
                            Textbox1.Text = (Convert.ToDecimal(opr1) / Convert.ToDecimal(opr2)).ToString();
                        opr1 = opr2;
                        Flag[3] = 1;
                    }
                    else if (Flag[3] == 1)
                    {
                        if (Convert.ToDecimal(opr2) == 0)
                            Textbox1.Text = "Undefined Result";
                        else
                            Textbox1.Text = (Convert.ToDecimal(opr2) / Convert.ToDecimal(opr1)).ToString();

                    }

                }
                else if (op == "√")
                {
                    if (Textbox1.Text.Contains("√(-)"))
                        Textbox1.Text = "Invalid Operation";
                    else if (res!="NULL")
                    {
                        Textbox1.Text = Math.Sqrt(Convert.ToDouble(res)).ToString();
                        res = "NULL";
                    }

                    else if (Textbox1.Text.EndsWith(")"))
                        Textbox1.Text = Math.Sqrt(Convert.ToDouble(opr1)).ToString();//include (()) case
                }

            }
            else if (Textbox1.Text == "3.1415926535")
                Textbox1.Text = Textbox1.Text;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Textbox1.Text = "0";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Textbox1.Text.Length == 1)
                Textbox1.Text = "0";
            else
                Textbox1.Text = Textbox1.Text.Substring(0, Textbox1.Text.Length - 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            opr1= Textbox1.Text;
            op = "/";
            flag = 1;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            opr1 = Textbox1.Text;
            op = "*";
            flag = 1;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Textbox1.Text == "0")
            {
                Textbox1.Text = "-";
            }
            else
            {
                opr1 = Textbox1.Text;
                op = "-";
                flag = 1;
                
            }
        }


        private void button22_Click(object sender, EventArgs e)
        {
            Textbox1.Text = "3.1415926535";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Textbox1.Text.Contains("."))
                Textbox1.Text = Textbox1.Text;
            else
                Textbox1.Text = Textbox1.Text + ".";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(Textbox1.Text) > 0)
                Textbox1.Text = "-" + Textbox1.Text;
            else if (Convert.ToDecimal(Textbox1.Text) < 0)
                Textbox1.Text = Textbox1.Text.Substring(1, Textbox1.Text.Length - 1);

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Textbox1.Text = "√(" + Textbox1.Text + ")";
            if (Textbox1.Text == "0")
            {
                opr1 = Textbox1.Text;
             }
            else
            {
                res = Textbox1.Text.TrimEnd(Remove).TrimStart(Remove);

            }
            op = "√";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            opr1 = Textbox1.Text;
            Textbox1.Text = (Convert.ToDecimal(opr1) / 100).ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                Textbox1.Text = "";
            if (Textbox1.Text == "-")
                Textbox1.Text = "0";
            if (Textbox1.Text.Contains("."))
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "0";
            }

            else
            {
                if (Textbox1.Text.StartsWith("0") || Textbox1.Text.Contains(" 0"))
                    Textbox1.Text = "0";
                else
                {
                    str = Textbox1.Text;
                    Textbox1.Text = str + "0";
                }
            }
            flag = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                Textbox1.Text = " ";
            if (Textbox1.Text == "-")
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "4";
            }
            else if (Textbox1.Text.Equals("0"))
                Textbox1.Text = "4";
            else
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "4";

            }
            flag = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                Textbox1.Text = " ";
            if (Textbox1.Text == "-")
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "8";
            }
            else if (Textbox1.Text.Equals("0"))
                Textbox1.Text = "8";
            else
            {
                str = Textbox1.Text;
                Textbox1.Text = str + "8";

            }
            flag = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            opr1 = Textbox1.Text;
            op = "+";
            flag = 1;
           
        }
    }
}
