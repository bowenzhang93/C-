using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_arithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        double a, b;
        string op;
        double result;

        Random rnd = new Random();

        void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            if (chbinner10.Checked == true)//10以内的加减乘除
            {
                a = rnd.Next(10) + 1;//生成操作数1
                b = rnd.Next(10) + 1;//生成操作数2
                int n = 4; //运算符个数
                int c = rnd.Next(n);
                GenerateMethod(c);
            }
            else if (chbinner100.Checked == true)//100以内的加减乘除
            {
                a = rnd.Next(100) + 1;//生成操作数1
                b = rnd.Next(100) + 1;//生成操作数2
                int n = 4; //运算符个数
                int c = rnd.Next(n);
                GenerateMethod(c);
            }
            else //10以内的乘法
            {
                a = rnd.Next(10) + 1;//生成操作数1
                b = rnd.Next(10) + 1;//生成操作数2
                int n = 1; //运算符个数
                int c = rnd.Next(n);
                GenerateMethod(c);
            }
        }

        private void GenerateMethod(int c)
        {
            txtEnterResult.Focus();
            if (chb10Mul.CheckState == CheckState.Checked || chbinner10.CheckState == CheckState.Checked || chbinner100.CheckState == CheckState.Checked)
            {
                switch (c)
                {
                    case 0: op = "*"; result = a * b; break;
                    case 1: op = "/"; result = a / b; break;
                    case 2: op = "+"; result = a + b; break;
                    case 3: op = "-"; result = a - b; break;
                }

                labNummer1.Text = a.ToString();
                labNummer2.Text = b.ToString();
                labOp.Text = op;
                txtEnterResult.Text = "";//将输入文本框的内容置为空
            }
            else
            {
                MessageBox.Show("请选择一种出题方式！");
                btnGenerate.Enabled = true;
            }

        }

        private void chbinner100_CheckedChanged(object sender, EventArgs e)
        {
            if (chbinner100.CheckState == CheckState.Checked)
            {
                chbinner10.Checked = false;
                chb10Mul.Checked = false;
                //chbinner100.Enabled = false; //这部分是可以隐藏被选框，并且是用户不能操作被选框了
                //chbinner10.Enabled = true;
                //chb10Mul.Enabled = true;
            }
        }

        private void chb10Mul_CheckedChanged(object sender, EventArgs e)
        {
            if (chb10Mul.CheckState == CheckState.Checked)
            {
                chbinner10.Checked = false;
                chbinner100.Checked = false;
                //chb10Mul.Enabled = false;
                //chbinner10.Enabled = true;
                //chbinner100.Enabled = true;
            }
        }

        private void chbAutoNext_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAutoNext.CheckState == CheckState.Checked)
            {
                timer1.Enabled = Enabled;
                //btnGenerate.Enabled = false;
            }
            else
            {
                timer1.Stop();
                btnGenerate.Enabled = true;
            }
        }
        //timer1开启时，点击出题按钮
        void timer1_Tick(object sender, EventArgs e)
        {
            btnGenerate.PerformClick();
        }
        
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //txtHistory.Focus();
            //txtHistory.Select(txtHistory.TextLength, 0);
            //txtHistory.ScrollToCaret();
            if (op=="/")
            {
                if (txtEnterResult.Text == result.ToString("0.00"))
                {
                    string disp = " " + a + " " + op + " " + b + " " + "=" + " " + result.ToString("0.00") + "\t" + "√" + "\r\n";
                    txtHistory.Text += disp;
                    btnGenerate.Enabled = true;
                    txtHistory.Select(txtHistory.Text.Length, 0);
                    txtHistory.ScrollToCaret();
                }
                else
                {
                    string disp = " " + a + " " + op + " " + b + " " + "=" + " " + txtEnterResult.Text + "\t" + "×" + "\r\n";
                    txtHistory.Text += disp;
                    txtEnterResult.Clear();
                    txtHistory.Select(txtHistory.Text.Length, 0);
                    txtHistory.ScrollToCaret();
                }
            }
            else
            {
                if (txtEnterResult.Text == result.ToString())
                {
                    string disp = " " + a + " " + op + " " + b + " " + "=" + " " + result + "\t" + "√" + "\r\n";
                    txtHistory.Text += disp;
                    btnGenerate.Enabled = true;
                    txtHistory.Select(txtHistory.Text.Length, 0);
                    txtHistory.ScrollToCaret();
                }
                else
                {
                    string disp = " " + a + " " + op + " " + b + " " + "=" + " " + txtEnterResult.Text + "\t" + "×" + "\r\n";
                    txtHistory.Text += disp;
                    txtEnterResult.Clear();
                    txtHistory.Select(txtHistory.Text.Length, 0);
                    txtHistory.ScrollToCaret();
                }
            }
            
        }

        void btnReset_Click(object sender, EventArgs e)
        {
            //resetpassword form2 = new resetpassword();
            //form2.ShowDialog();//打开新窗体
            //this.Hide();//将本窗体隐藏
            txtHistory.Clear();
            txtEnterResult.Clear();
            labNummer1.Text = "0";
            labNummer2.Text = "0";
            labOp.Text = "+";
            chb10Mul.CheckState = CheckState.Unchecked;
            chbinner10.CheckState = CheckState.Unchecked;
            chbinner100.CheckState = CheckState.Unchecked;
            btnGenerate.Enabled = true;
            if (chbAutoNext.CheckState == CheckState.Checked)
            {
                chbAutoNext.CheckState = CheckState.Unchecked;
            }
        }



        //private void btnCheck_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar==)
        //    {

        //    }
        //}

        private void chbinner10_CheckedChanged(object sender, EventArgs e)
        {
            if (chbinner10.CheckState == CheckState.Checked)
            {
                chb10Mul.Checked = false;
                chbinner100.Checked = false;
                //chbinner10.Enabled = false;
                //chb10Mul.Enabled = true;
                //chbinner100.Enabled = true;
            }
        }
    }
}
