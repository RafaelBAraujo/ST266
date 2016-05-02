using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelCalc
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        double num1 = 0.0, num2 = 0.0,resultado=0.0;
        int flag_num = 1;
        private void completar_textbox(string n)
        {
            int tam = textBox1.TextLength;
            string str = textBox1.Text;
            if ((tam==1)&&(str=="0"))
                textBox1.Text = "";

            textBox1.Text = textBox1.Text + n;
        }

        private void botao_0_Click(object sender, EventArgs e)
        {
            completar_textbox("0");
        }

        private void botao_1_Click(object sender, EventArgs e)
        {
            completar_textbox("1");
        }

        private void botao_2_Click(object sender, EventArgs e)
        {
            completar_textbox("2");
        }

        private void botao_3_Click(object sender, EventArgs e)
        {
            completar_textbox("3");
        }

        private void botao_4_Click(object sender, EventArgs e)
        {
            completar_textbox("4");
        }

        private void botao_5_Click(object sender, EventArgs e)
        {
            completar_textbox("5");
        }

        private void botao_6_Click(object sender, EventArgs e)
        {
            completar_textbox("6");
        }

        private void botao_7_Click(object sender, EventArgs e)
        {
            completar_textbox("7");
        }

        private void botao_8_Click(object sender, EventArgs e)
        {
            completar_textbox("8");
        }

        private void botao_9_Click(object sender, EventArgs e)
        {
            completar_textbox("9");
        }

        private void botao_limpar_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            textBox1.Text = "0";
        }

        private void botao_apagar_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);

                if (textBox1.TextLength == 0)
                    textBox1.Text = "0";
            }
            else
                textBox1.Text = "0";
        }

        bool existe_virgula = false;

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int carac = Convert.ToInt16(e.KeyChar);
            switch (carac)
            {
                //FAZER BOTÃO ESC PARA O CLEAR
                case 8:
                    if (textBox1.TextLength != 0)
                    {
                        if (textBox1.Text[textBox1.TextLength - 1] == ',')
                            existe_virgula = false;

                        textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);

                        if (textBox1.TextLength == 0)
                            textBox1.Text = "0";
                    }
                    else
                        textBox1.Text = "0";
                    break;
                case 43:
                    if (flag_num == 1)
                    {
                        num1 = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = "";
                        flag_num = 2;
                    }
                    else
                    {
                        num2 = num1 + Convert.ToDouble(textBox1.Text);
                        flag_num = 1;
                    }
                    break;
                case 44:
                    if (!existe_virgula)
                    {
                        int tam = textBox1.TextLength;
                        string str = textBox1.Text;
                        if ((tam == 1) && (str == "0"))
                            completar_textbox("0,");
                        else
                            completar_textbox(",");
                        existe_virgula = true;
                    }
                    break;
                case 46:
                    if (!existe_virgula)
                    {
                        int tam = textBox1.TextLength;
                        string str = textBox1.Text;
                        if ((tam == 1) && (str == "0"))
                            completar_textbox("0,");
                        else
                            completar_textbox(",");
                        existe_virgula = true;
                    }
                    break;
                case 48:
                    completar_textbox("0");
                    break;
                case 49:
                    completar_textbox("1");
                    break;
                case 50:
                    completar_textbox("2");
                    break;
                case 51:
                    completar_textbox("3");
                    break;
                case 52:
                    completar_textbox("4");
                    break;
                case 53:
                    completar_textbox("5");
                    break;
                case 54:
                    completar_textbox("6");
                    break;
                case 55:
                    completar_textbox("7");
                    break;
                case 56:
                    completar_textbox("8");
                    break;
                case 57:
                    completar_textbox("9");
                    break;
            }
        }

        private void botao_virgula_Click(object sender, EventArgs e)
        {
            if (!existe_virgula)
            {
                int tam = textBox1.TextLength;
                string str = textBox1.Text;
                if ((tam == 1) && (str == "0"))
                    completar_textbox("0,");
                else
                    completar_textbox(",");
                existe_virgula = true;
            }        
        }

        private void botao_somar_Click(object sender, EventArgs e)
        {
            if (flag_num == 1)
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                flag_num = 2;
            }
            else
            {
                num2 = num1+Convert.ToDouble(textBox1.Text);
                flag_num = 1;
            }
        }

        private double somar()
        {
            return num1 + num2;
        }
    }
}

