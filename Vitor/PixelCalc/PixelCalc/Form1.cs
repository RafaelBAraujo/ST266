using System;
using System.Windows.Forms;

namespace PixelCalc
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        int count;
        double num1 = 0.0, resp = 0.0;

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
            count = 0;
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
                // Backspace
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
                // Enter
                case 13:
                    calcular(count);
                    break;
                // ESC (limpar)
                case 27:
                    count = 0;
                    textBox1.Text = "0";
                    break;
                // * (Multiplicação)
                case 42:
                    if (textBox1.Text != "")
                    {
                        num1 = float.Parse(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Focus();
                        count = 3;
                        existe_virgula = false;
                    }
                    break;
                // + (Adição)
                case 43:
                    if (textBox1.Text != "")
                    {
                        num1 = float.Parse(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Focus();
                        count = 1;
                        existe_virgula = false;
                    }
                    break;
                // Vírgula
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
                // - (Subtração)
                case 45:
                    if (textBox1.Text != "")
                    {
                        num1 = float.Parse(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Focus();
                        count = 2;
                        existe_virgula = false;
                    }
                    break;
                // Ponto (Vírgula)
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
                // / (Divisão)
                case 47:
                    if (textBox1.Text != "")
                    {
                        num1 = float.Parse(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Focus();
                        count = 1;
                        existe_virgula = false;
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
                // = (igual)
                case 61:
                    calcular(count);
                    break;
            }
        }

        private void botao_virgula_Click(object sender, EventArgs e)
        {
            if (!existe_virgula)
            {
                if ((textBox1.TextLength == 1) && (textBox1.Text == "0"))
                    completar_textbox("0,");
                else
                    completar_textbox(",");
                existe_virgula = true;
            }        
        }

        private void botao_somar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
                existe_virgula = false; 
            }
        }

        private void botao_subtrair_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
                existe_virgula = false;
            }
        }
   
        private void botao_multiplicar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 3;
                existe_virgula = false;
            }
        }

        private void botao_dividir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 4;
                existe_virgula = false;
            }
        }

        private void botao_igual_Click(object sender, EventArgs e)
        {
            calcular(count);
        }

        int check = 1;
        private void botao_maisoumenos_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                if (textBox1.TextLength > 0)
                {
                    string text = textBox1.Text;
                    if (check == 1)
                    {
                        textBox1.Text = "-" + textBox1.Text;
                        check = 2;
                    }
                    else if (check == 2)
                    {
                        int lenght = textBox1.TextLength; textBox1.Clear();
                        for (int i = 1; i < lenght; i++)
                        {
                            textBox1.Text = textBox1.Text + text[i];
                        }
                        check = 1;
                    }
                }
                else
                {
                    textBox1.Text = "-";
                }
            }
        }

        public void calcular(int count)
        {
            switch(count)
            {
                case 1:
                    resp = num1 + double.Parse(textBox1.Text);
                    textBox1.Text = resp.ToString();
                    break;
                case 2:
                    resp = num1 - double.Parse(textBox1.Text);
                    textBox1.Text = resp.ToString();
                    break;
                case 3:
                    resp = num1 * double.Parse(textBox1.Text);
                    textBox1.Text = resp.ToString();
                    break;
                case 4:
                    resp = num1 / double.Parse(textBox1.Text);
                    textBox1.Text = resp.ToString();
                    break;
            }
            int aux = Convert.ToInt16(resp);
            if (resp == aux)
                existe_virgula = false;
            else
                existe_virgula = true;
        }
    }
}

