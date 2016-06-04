using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace PixelCalc
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        int count,cor_ativ=0;       
        int tipo_exib=1; //padrão é Decimal
                         // 1-Decimal 2-Hexa 3-Octal 4-Binário
        float num1 = 0.0F, resp = 0.0F;
        string resFinal;

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

        private void botao_A_Click(object sender, EventArgs e)
        {
            completar_textbox("A");
        }

        private void botao_B_Click(object sender,EventArgs e)
        {
            completar_textbox("B");
        }

        private void botao_C_Click(object sender, EventArgs e)
        {
            completar_textbox("C");
        }

        private void botao_D_Click(object sender, EventArgs e)
        {
            completar_textbox("D");
        }

        private void botao_E_Click(object sender, EventArgs e)
        {
            completar_textbox("E");
        }

        private void botao_F_Click(object sender, EventArgs e)
        {
            completar_textbox("F");
        }

        private void botao_limpar_Click(object sender, EventArgs e)
        {
            count = 0;
            textBox1.Text = "0";
            existe_virgula = false;
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
            if (cor_ativ==0)
            {
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
                        RB_Decimal.Enabled = true;
                        RB_Hexadecimal.Enabled = true;
                        RB_Octal.Enabled = true;
                        RB_Binario.Enabled = true;
                        break;
                    // ESC (limpar)
                    case 27:
                        count = 0;
                        textBox1.Text = "0";
                        existe_virgula = false;
                        break;
                    // * (Multiplicação)
                    case 42:
                        if (textBox1.Text != "")
                        {
                            if (tipo_exib != 1)
                            {
                                switch (tipo_exib)
                                {
                                    case 2:
                                        Converter_Base(16, 10);
                                        break;
                                    case 3:
                                        Converter_Base(8, 10);
                                        break;
                                    case 4:
                                        Converter_Base(2, 10);
                                        break;
                                }
                                num1 = float.Parse(resFinal);
                            }
                            else
                            {
                                num1 = float.Parse(textBox1.Text);
                            }

                            textBox1.Clear();
                            textBox1.Focus();
                            count = 3;
                            existe_virgula = false;
                            RB_Binario.Enabled = false;
                            RB_Decimal.Enabled = false;
                            RB_Hexadecimal.Enabled = false;
                            RB_Octal.Enabled = false;
                            group_box1.Focus();
                        }
                        break;
                    // + (Adição)
                    case 43:
                        if (textBox1.Text != "")
                        {
                            if (tipo_exib != 1)
                            {
                                switch (tipo_exib)
                                {
                                    case 2:
                                        Converter_Base(16, 10);
                                        break;
                                    case 3:
                                        Converter_Base(8, 10);
                                        break;
                                    case 4:
                                        Converter_Base(2, 10);
                                        break;
                                }
                                num1 = float.Parse(resFinal);
                            }
                            else
                            {
                                num1 = float.Parse(textBox1.Text);
                            }

                            textBox1.Clear();
                            textBox1.Focus();
                            count = 1;
                            existe_virgula = false;
                            RB_Binario.Enabled = false;
                            RB_Decimal.Enabled = false;
                            RB_Hexadecimal.Enabled = false;
                            RB_Octal.Enabled = false;
                            group_box1.Focus();
                        }
                        break;
                    // Vírgula
                    case 44:
                        if (botao_virgula.Enabled == true)
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
                        break;
                    // - (Subtração)
                    case 45:
                        if (textBox1.Text != "")
                        {
                            if (tipo_exib != 1)
                            {
                                switch (tipo_exib)
                                {
                                    case 2:
                                        Converter_Base(16, 10);
                                        break;
                                    case 3:
                                        Converter_Base(8, 10);
                                        break;
                                    case 4:
                                        Converter_Base(2, 10);
                                        break;
                                }
                                num1 = float.Parse(resFinal);
                            }
                            else
                            {
                                num1 = float.Parse(textBox1.Text);
                            }

                            textBox1.Clear();
                            textBox1.Focus();
                            count = 2;
                            existe_virgula = false;
                            RB_Binario.Enabled = false;
                            RB_Decimal.Enabled = false;
                            RB_Hexadecimal.Enabled = false;
                            RB_Octal.Enabled = false;
                            group_box1.Focus();
                        }
                        break;
                    // Ponto (Vírgula)
                    case 46:
                        if (botao_virgula.Enabled == true)
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
                        break;
                    // / (Divisão)
                    case 47:
                        if (textBox1.Text != "")
                        {
                            if (tipo_exib != 1)
                            {
                                switch (tipo_exib)
                                {
                                    case 2:
                                        Converter_Base(16, 10);
                                        break;
                                    case 3:
                                        Converter_Base(8, 10);
                                        break;
                                    case 4:
                                        Converter_Base(2, 10);
                                        break;
                                }
                                num1 = float.Parse(resFinal);
                            }
                            else
                            {
                                num1 = float.Parse(textBox1.Text);
                            }

                            textBox1.Clear();
                            textBox1.Focus();
                            count = 4;
                            existe_virgula = false;
                            RB_Binario.Enabled = false;
                            RB_Decimal.Enabled = false;
                            RB_Hexadecimal.Enabled = false;
                            RB_Octal.Enabled = false;
                            group_box1.Focus();
                        }
                        break;
                    case 48:
                        completar_textbox("0");
                        break;
                    case 49:
                        completar_textbox("1");
                        break;
                    case 50:
                        if (botao_2.Enabled == true)
                            completar_textbox("2");
                        break;
                    case 51:
                        if (botao_3.Enabled == true)
                            completar_textbox("3");
                        break;
                    case 52:
                        if (botao_4.Enabled == true)
                            completar_textbox("4");
                        break;
                    case 53:
                        if (botao_5.Enabled == true)
                            completar_textbox("5");
                        break;
                    case 54:
                        if (botao_6.Enabled == true)
                            completar_textbox("6");
                        break;
                    case 55:
                        if (botao_7.Enabled == true)
                            completar_textbox("7");
                        break;
                    case 56:
                        if (botao_8.Enabled == true)
                            completar_textbox("8");
                        break;
                    case 57:
                        if (botao_9.Enabled == true)
                            completar_textbox("9");
                        break;
                    // = (igual)
                    case 61:
                        calcular(count);
                        RB_Decimal.Enabled = true;
                        RB_Hexadecimal.Enabled = true;
                        RB_Octal.Enabled = true;
                        RB_Binario.Enabled = true;
                        break;
                    // A
                    case 65:
                        if (botao_A.Enabled == true)
                            completar_textbox("A");
                        break;
                    case 97:
                        if (botao_A.Enabled == true)
                            completar_textbox("A");
                        break;
                    //B
                    case 66:
                        if (botao_B.Enabled == true)
                            completar_textbox("B");
                        break;
                    case 98:
                        if (botao_B.Enabled == true)
                            completar_textbox("B");
                        break;
                    //C
                    case 67:
                        if (botao_C.Enabled == true)
                            completar_textbox("C");
                        break;
                    case 99:
                        if (botao_C.Enabled == true)
                            completar_textbox("C");
                        break;
                    //D
                    case 68:
                        if (botao_D.Enabled == true)
                            completar_textbox("D");
                        break;
                    case 100:
                        if (botao_D.Enabled == true)
                            completar_textbox("D");
                        break;
                    //E
                    case 69:
                        if (botao_E.Enabled == true)
                            completar_textbox("E");
                        break;
                    case 101:
                        if (botao_E.Enabled == true)
                            completar_textbox("E");
                        break;
                    //F
                    case 70:
                        if (botao_F.Enabled == true)
                            completar_textbox("F");
                        break;
                    case 102:
                        if (botao_F.Enabled == true)
                            completar_textbox("F");
                        break;
                }
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
                if (tipo_exib != 1)
                {
                    switch (tipo_exib)
                    {
                        case 2:
                            Converter_Base(16, 10);
                            break;
                        case 3:
                            Converter_Base(8, 10);
                            break;
                        case 4:
                            Converter_Base(2, 10);
                            break;
                    }
                    num1 = float.Parse(resFinal);
                }
                else
                {
                    num1 = float.Parse(textBox1.Text);
                }

                textBox1.Clear();
                textBox1.Focus();
                count = 1;
                existe_virgula = false;
                RB_Binario.Enabled = false;
                RB_Decimal.Enabled = false;
                RB_Hexadecimal.Enabled = false;
                RB_Octal.Enabled = false;
                group_box1.Focus();
            }
        }

        private void botao_subtrair_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (tipo_exib != 1)
                {
                    switch (tipo_exib)
                    {
                        case 2:
                            Converter_Base(16, 10);
                            break;
                        case 3:
                            Converter_Base(8, 10);
                            break;
                        case 4:
                            Converter_Base(2, 10);
                            break;
                    }
                    num1 = float.Parse(resFinal);
                }
                else
                {
                    num1 = float.Parse(textBox1.Text);
                }

                textBox1.Clear();
                textBox1.Focus();
                count = 2;
                existe_virgula = false;
                RB_Binario.Enabled = false;
                RB_Decimal.Enabled = false;
                RB_Hexadecimal.Enabled = false;
                RB_Octal.Enabled = false;
                group_box1.Focus();
            }
        }

        private void botao_multiplicar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (tipo_exib != 1)
                {
                    switch (tipo_exib)
                    {
                        case 2:
                            Converter_Base(16, 10);
                            break;
                        case 3:
                            Converter_Base(8, 10);
                            break;
                        case 4:
                            Converter_Base(2, 10);
                            break;
                    }
                    num1 = float.Parse(resFinal);
                }
                else
                {
                    num1 = float.Parse(textBox1.Text);
                }

                textBox1.Clear();
                textBox1.Focus();
                count = 3;
                existe_virgula = false;
                RB_Binario.Enabled = false;
                RB_Decimal.Enabled = false;
                RB_Hexadecimal.Enabled = false;
                RB_Octal.Enabled = false;
                group_box1.Focus();
            }
        }

        private void botao_dividir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (tipo_exib != 1)
                {
                    switch (tipo_exib)
                    {
                        case 2:
                            Converter_Base(16, 10);
                            break;
                        case 3:
                            Converter_Base(8, 10);
                            break;
                        case 4:
                            Converter_Base(2, 10);
                            break;
                    }
                    num1 = float.Parse(resFinal);
                }
                else
                {
                    num1 = float.Parse(textBox1.Text);
                }

                textBox1.Clear();
                textBox1.Focus();
                count = 4;
                existe_virgula = false;
                RB_Binario.Enabled = false;
                RB_Decimal.Enabled = false;
                RB_Hexadecimal.Enabled = false;
                RB_Octal.Enabled = false;
                group_box1.Focus();
            }
        }

        private void botao_igual_Click(object sender, EventArgs e)
        {
            calcular(count);
            RB_Binario.Enabled = true;
            RB_Decimal.Enabled = true;
            RB_Hexadecimal.Enabled = true;
            RB_Octal.Enabled = true;
        }

        int check = 1;//variável auxiliar ao método do botao +-

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

        private void calcular(int count)
        {
            if (textBox1.Text != "")
            {
                switch (count)
                {
                    case 1:
                        if (tipo_exib == 1)
                        {
                            resp = num1 + float.Parse(textBox1.Text);
                            textBox1.Text = resp.ToString();
                        }
                        else if (tipo_exib == 2)
                        {
                            Converter_Base(16, 10);
                            resp = num1 + float.Parse(resFinal);
                            textBox1.Text = resp.ToString();
                            Converter_Base(10, 16);
                        }
                        else if (tipo_exib == 3)
                        {
                            Converter_Base(8, 10);
                            resp = num1 + float.Parse(resFinal);
                            textBox1.Text = resp.ToString();
                            Converter_Base(10, 8);
                        }
                        else if (tipo_exib == 4)
                        {
                            Converter_Base(2, 10);
                            resp = num1 + float.Parse(resFinal);
                            textBox1.Text = resp.ToString();
                            Converter_Base(10, 2);
                        }
                        break;
                    case 2:
                        if (tipo_exib == 1)
                        {
                            resp = num1 - float.Parse(textBox1.Text);
                            textBox1.Text = resp.ToString();
                        }
                        else if (tipo_exib == 2)
                        {
                            Converter_Base(16, 10);
                            resp = num1 - float.Parse(resFinal);
                            textBox1.Text = resp.ToString();
                            Converter_Base(10, 16);
                        }
                        else if (tipo_exib == 3)
                        {
                            Converter_Base(8, 10);
                            resp = num1 - float.Parse(resFinal);
                            textBox1.Text = resp.ToString();
                            Converter_Base(10, 8);
                        }
                        else if (tipo_exib == 4)
                        {
                            Converter_Base(2, 10);
                            resp = num1 - float.Parse(resFinal);
                            textBox1.Text = resp.ToString();
                            Converter_Base(10, 2);
                        }
                        break;
                        case 3:
                        if (tipo_exib == 1)
                        {
                            resp = num1 * float.Parse(textBox1.Text);
                            textBox1.Text = resp.ToString();
                        }
                        else if (tipo_exib == 2)
                        {
                            Converter_Base(16, 10);
                            resp = num1 * float.Parse(resFinal);
                            textBox1.Text = resp.ToString();
                            Converter_Base(10, 16);
                        }
                        else if (tipo_exib == 3)
                        {
                            Converter_Base(8, 10);
                            resp = num1 * float.Parse(resFinal);
                            textBox1.Text = resp.ToString();
                            Converter_Base(10, 8);
                        }
                        else if (tipo_exib == 4)
                        {
                            Converter_Base(2, 10);
                            resp = num1 * float.Parse(resFinal);
                            textBox1.Text = resp.ToString();
                            Converter_Base(10, 2);
                        }
                        break;
                    case 4:
                        if (tipo_exib == 1)
                        {
                            resp = num1 / float.Parse(textBox1.Text);
                            textBox1.Text = resp.ToString();
                        }
                        else if (tipo_exib == 2)
                        {
                            Converter_Base(16, 10);
                            resp = num1 / float.Parse(resFinal);
                            textBox1.Text = resp.ToString();
                            Converter_Base(10, 16);
                        }
                        else if (tipo_exib == 3)
                        {
                            Converter_Base(8, 10);
                            resp = num1 / float.Parse(resFinal);
                            textBox1.Text = resp.ToString();
                            Converter_Base(10, 8);
                        }
                        else if (tipo_exib == 4)
                        {
                            Converter_Base(2, 10);
                            resp = num1 / float.Parse(resFinal);
                            textBox1.Text = resp.ToString();
                            Converter_Base(10, 2);
                        }
                        break;
                }
                long aux = Convert.ToInt64(resp);
                if (resp == aux)
                    existe_virgula = false;
                else
                    existe_virgula = true;
            }

        }

        private void RB_Decimal_CheckedChanged(object sender, EventArgs e)
        {
            switch (tipo_exib)
            {
                //Base Hexadecimal
                case 2:
                    Converter_Base(16, 10);
                    botao_A.Visible = false;
                    botao_B.Visible = false;
                    botao_C.Visible = false;
                    botao_D.Visible = false;
                    botao_E.Visible = false;
                    botao_E.Visible = false;
                    botao_A.Enabled = false;
                    botao_B.Enabled = false;
                    botao_C.Enabled = false;
                    botao_D.Enabled = false;
                    botao_E.Enabled = false;
                    botao_E.Enabled = false;
                    Height = 255;  
                    break;
                //Base Octal
                case 3:
                    Converter_Base(8, 10);
                    break;
                //Base Binária
                case 4:
                    Converter_Base(2, 10);
                    break;
            }
            tipo_exib = 1;
            if (textBox1.TextLength < 20)
                textBox1.Font = new Font(textBox1.Font.FontFamily, 22);

            botao_virgula.Enabled = true;
            botao_maisoumenos.Enabled = true;
            botao_2.Enabled = true;
            botao_3.Enabled = true;
            botao_4.Enabled = true;
            botao_5.Enabled = true;
            botao_6.Enabled = true;
            botao_7.Enabled = true;
            botao_8.Enabled = true;
            botao_9.Enabled = true;
        }

        private void RB_Hexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            Height = 290;
            botao_A.Visible = true;
            botao_B.Visible = true;
            botao_C.Visible = true;
            botao_D.Visible = true;
            botao_E.Visible = true;
            botao_F.Visible = true;
            botao_A.Enabled = true;
            botao_B.Enabled = true;
            botao_C.Enabled = true;
            botao_D.Enabled = true;
            botao_E.Enabled = true;
            botao_F.Enabled = true;

            switch (tipo_exib)
            {
                //Base Decimal
                case 1:
                    Converter_Base(10,16);
                    break;
                //Base Octal
                case 3:
                    Converter_Base(8,16);
                    break;
                //Base Binária
                case 4:
                    Converter_Base(2, 16);
                    break;
            }
            if (textBox1.TextLength < 20)
                textBox1.Font = new Font(textBox1.Font.FontFamily, 22);
            tipo_exib = 2;

            botao_virgula.Enabled = false;
            existe_virgula = false;
            botao_maisoumenos.Enabled = false;
            botao_2.Enabled = true;
            botao_3.Enabled = true;
            botao_4.Enabled = true;
            botao_5.Enabled = true;
            botao_6.Enabled = true;
            botao_7.Enabled = true;
            botao_8.Enabled = true;
            botao_9.Enabled = true;
        }

        private void RB_Octal_CheckedChanged(object sender, EventArgs e)
        {
            switch (tipo_exib)
            {
                //Base Decimal
                case 1:
                    Converter_Base(10, 8);
                    break;
                //Base HexaDecimal
                case 2:
                    Converter_Base(16,8);
                    botao_A.Visible = false;
                    botao_B.Visible = false;
                    botao_C.Visible = false;
                    botao_D.Visible = false;
                    botao_E.Visible = false;
                    botao_F.Visible = false;
                    botao_A.Enabled = false;
                    botao_B.Enabled = false;
                    botao_C.Enabled = false;
                    botao_D.Enabled = false;
                    botao_E.Enabled = false;
                    botao_F.Enabled = false;
                    Height = 255;
                    break;
                //Base Binária
                case 4:
                    Converter_Base(2,8);
                    break;
            }
            if (textBox1.TextLength < 20)
                textBox1.Font = new Font(textBox1.Font.FontFamily, 22);
            tipo_exib = 3;

            botao_virgula.Enabled = false;
            existe_virgula = false;
            botao_2.Enabled = true;
            botao_3.Enabled = true;
            botao_4.Enabled = true;
            botao_5.Enabled = true;
            botao_6.Enabled = true;
            botao_7.Enabled = true;
            botao_8.Enabled = false;
            botao_9.Enabled = false;
            botao_maisoumenos.Enabled = false;
        }

        private void RB_Binario_CheckedChanged(object sender, EventArgs e)
        {
            switch (tipo_exib)
            {
                //Base Decimal
                case 1:
                    Converter_Base(10, 2);
                    break;
                //Base HexaDecimal
                case 2:
                    Converter_Base(16, 2);
                    botao_A.Visible = false;
                    botao_B.Visible = false;
                    botao_C.Visible = false;
                    botao_D.Visible = false;
                    botao_E.Visible = false;
                    botao_F.Visible = false;
                    botao_A.Enabled = false;
                    botao_B.Enabled = false;
                    botao_C.Enabled = false;
                    botao_D.Enabled = false;
                    botao_E.Enabled = false;
                    botao_F.Enabled = false;
                    Height = 255;
                    break;
                //Base Octal
                case 3:
                    Converter_Base(8, 2);
                    break;
            }
            tipo_exib = 4;
            if (textBox1.TextLength > 20)
                textBox1.Font = new Font(textBox1.Font.FontFamily, 14);

            botao_virgula.Enabled = false;
            existe_virgula = false;
            botao_maisoumenos.Enabled = false;
            botao_2.Enabled = false;
            botao_3.Enabled = false;
            botao_4.Enabled = false;
            botao_5.Enabled = false;
            botao_6.Enabled = false;
            botao_7.Enabled = false;
            botao_8.Enabled = false;
            botao_9.Enabled = false;
        }

        private void text_R1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void text_G1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void text_B1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void text_R2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void text_G2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void text_B2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((char.IsLetter(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void botao_SomarCor_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt16(text_R1.Text) > 255) || (Convert.ToInt16(text_R2.Text) > 255) || (Convert.ToInt16(text_G1.Text) > 255) || (Convert.ToInt16(text_G2.Text) > 255) || (Convert.ToInt16(text_B1.Text) > 255) || (Convert.ToInt16(text_B2.Text) > 255))
            {
                MessageBox.Show("Digite valor(es) menor(es) que 255");
            }
            else if ((Convert.ToInt16(text_R1.Text) < 0) || (Convert.ToInt16(text_R2.Text) < 0) || (Convert.ToInt16(text_G1.Text) < 0) || (Convert.ToInt16(text_G2.Text) < 0) || (Convert.ToInt16(text_B1.Text) < 0) || (Convert.ToInt16(text_B2.Text) < 0))
            {
                MessageBox.Show("Digite valor(es) positivo(s)");
            }
            else
            {
                int R = Convert.ToInt16(text_R1.Text) + Convert.ToInt16(text_R2.Text);
                int G = Convert.ToInt16(text_G1.Text) + Convert.ToInt16(text_G2.Text);
                int B = Convert.ToInt16(text_B1.Text) + Convert.ToInt16(text_B2.Text);

                if (R > 255)R = 255;
                if (G > 255) G = 255;
                if (B > 255) B = 255;

                pictureBox1.BackColor = Color.FromArgb(R,G,B);
            }
        }

        private void botao_SubtrairCor_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt16(text_R1.Text) > 255) || (Convert.ToInt16(text_R2.Text) > 255) || (Convert.ToInt16(text_G1.Text) > 255) || (Convert.ToInt16(text_G2.Text) > 255) || (Convert.ToInt16(text_B1.Text) > 255) || (Convert.ToInt16(text_B2.Text) > 255))
            {
                MessageBox.Show("Digite valor(es) menor(es) que 255");
            }
            else if ((Convert.ToInt16(text_R1.Text) < 0) || (Convert.ToInt16(text_R2.Text) < 0) || (Convert.ToInt16(text_G1.Text) < 0) || (Convert.ToInt16(text_G2.Text) < 0) || (Convert.ToInt16(text_B1.Text) < 0) || (Convert.ToInt16(text_B2.Text) < 0))
            {
                MessageBox.Show("Digite valor(es) positivo(s)");
            }
            else
            {
                int R = Convert.ToInt16(text_R1.Text) - Convert.ToInt16(text_R2.Text);
                int G = Convert.ToInt16(text_G1.Text) - Convert.ToInt16(text_G2.Text);
                int B = Convert.ToInt16(text_B1.Text) - Convert.ToInt16(text_B2.Text);

                if (R < 0) R = 0;
                if (G < 0) G = 0;
                if (B < 0) B = 0;

                pictureBox1.BackColor = Color.FromArgb(R, G, B);
            }
        }

        private void text_R1_TextChanged(object sender, EventArgs e)
        {
            if (text_R1.Text == "")
                text_R1.Text = "0";
        }

        private void text_G1_TextChanged(object sender, EventArgs e)
        {
            if (text_G1.Text == "")
                text_G1.Text = "0";
        }

        private void text_B1_TextChanged(object sender, EventArgs e)
        {
            if (text_B1.Text == "")
                text_B1.Text = "0";
        }

        private void text_R2_TextChanged(object sender, EventArgs e)
        {
            if (text_R2.Text == "")
                text_R2.Text = "0";
        }

        private void text_G2_TextChanged(object sender, EventArgs e)
        {
            if (text_G2.Text == "")
                text_G2.Text = "0";
        }

        private void text_B2_TextChanged(object sender, EventArgs e)
        {
            if (text_B2.Text == "")
                text_B2.Text = "0";
        }

        private void botao_cor_Click(object sender, EventArgs e)
        {
            if (cor_ativ==0)//Desativado
            {
                cor_ativ = 1;
                Width = 650;
            }
            else//Ativado
            {
                cor_ativ = 0;
                Width = 380;
                text_R1.Text = "0";
                text_R2.Text = "0";
                text_G1.Text = "0";
                text_G2.Text = "0";
                text_B1.Text = "0";
                text_B2.Text = "0";
                pictureBox1.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void Converter_Base(int baseorigem, int basedestino)
        {
            long resParcial;
            int qtdCaracteres, aux2, restoMod;
            string caracteres = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ", numDigitado, aux, baseValida;
            float aux3 = 0.0F;
            //limpar variáveis para próximos cálculos
            baseValida = "1";
            resParcial = 0;
            resFinal = null;

            //retirando vírgula do número digitado caso exista. Variável aux2 será reutilizada posteriormente
            //válido somente para modo de exibição decimal porque nos outros modos não há como inserir vírgula
            if (tipo_exib == 1)
            {
                aux3 = float.Parse(textBox1.Text);
                aux2 = (int)aux3;
                textBox1.Text = Convert.ToString(aux2);
                aux2 = 0;
            }

            //guardar quantidade de caracteres do número
            qtdCaracteres = textBox1.Text.Trim().Length;
            //guardar número digitado em caixa alta
            numDigitado = textBox1.Text.ToUpper();

            //#########################################################################//
            //###### verificar se o número tem caracteres fora da base informada ######//
            //#########################################################################//
            for (int a = 0; a < qtdCaracteres; a++)
            {
                //se a variavel de controle estiver em 1
                if (baseValida == "1")
                {
                    //verificar se cada caractere digitado está dentro do limite da base informada
                    for (int x = baseorigem; x < caracteres.Length; x++)
                    {
                        //se os caracteres digitados pertencerem a base informada, atribuir 1 a variavel de controle
                        if (!numDigitado.Contains(caracteres[x]))
                        {
                            baseValida = "1";
                        }
                        //se nao pertencer, guardar na variavel de controle o caracter fora da base para mostrar na mensagem de erro
                        else
                        {
                            baseValida = caracteres[x].ToString();
                            break;
                        }
                    }
                }
            }
            //se os caracteres estiverem todos dentro da base informada faz o cálculo
            if (baseValida == "1")
            {
                //#########################################################################//
                //########### primeiro loop converte qualquer base para decimal ###########//
                //#########################################################################//

                //rodar loop x vezes, onde x é igual a quantidade de caracteres do número digitado
                for (int i = 1; i <= qtdCaracteres; i++)
                {
                    //pegar o último caracter do número digitado
                    aux = numDigitado[qtdCaracteres - i].ToString();
                    //pegar o caracter x da string de caracteres, onde x é o último caracter do número digitado
                    aux2 = caracteres.IndexOf(aux);
                    //elevar a base do número pelo caracter que está sendo verificado
                    //lembrando que deve-se fazer da direita para esquerda, começando pelo 0
                    //e após isso multiplicar pelo número da numAux2
                    resParcial = resParcial + aux2 * (Convert.ToInt64(Math.Pow(baseorigem,(i - 1))));
                }

                //#########################################################################//
                //### segundo loop converte número anterior(decimal) para qualquer base ###//
                //#########################################################################//

                //enquanto o resParcial for menor que a base de destino
                while (resParcial >= basedestino)
                {
                    //guarda o resto da divisão entre o número e a base
                    restoMod = Convert.ToInt32(resParcial % basedestino);
                    //atribui um novo valor ao resParcial dividindo-o pela base de destino
                    resParcial = resParcial / basedestino;
                    //guarda na string o caractere da variavel 'caracteres' correspondente a posicao do resto da divisão
                    resFinal = caracteres.Substring(restoMod, 1) + resFinal;
                }
                //guarda o último resto das divisões
                resFinal = caracteres[int.Parse(resParcial.ToString())].ToString() + resFinal;
                textBox1.Text = resFinal;
            }
            //se os caracteres digitados NÃO pertencerem a base informada, mostrar mensagem de erro
            else
            {
                MessageBox.Show("O número digitado possui caracteres além da base de origem informada: " + baseValida, "Base inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}