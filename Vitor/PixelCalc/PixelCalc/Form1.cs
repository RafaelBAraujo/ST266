using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace PixelCalc
{
    public partial class botao_cor : Form
    { 
        public botao_cor()
        {
            InitializeComponent();
        }

        int count;
       
        int tipo_exib=1; //padrão é Decimal
                         // 1-Decimal 2-Hexa 3-Octal 4-Binário

        float num1 = 0.0F, resp = 0.0F;

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
                    existe_virgula = false;
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
                        count = 4;
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
            if (textBox1.Text != "")
            {
                switch (count)
                {
                    case 1:
                        resp = num1 + float.Parse(textBox1.Text);
                        textBox1.Text = resp.ToString();
                        break;
                    case 2:
                        resp = num1 - float.Parse(textBox1.Text);
                        textBox1.Text = resp.ToString();
                        break;
                    case 3:
                        resp = num1 * float.Parse(textBox1.Text);
                        textBox1.Text = resp.ToString();
                        break;
                    case 4:
                        resp = num1 / float.Parse(textBox1.Text);
                        textBox1.Text = resp.ToString();
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
            botao_virgula.Enabled = true;
            switch (tipo_exib)
            {
                //Base Hexadecimal
                case 2:
                    Converter_Base(16, 10);
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
        }

        private void RB_Hexadecimal_CheckedChanged(object sender, EventArgs e)
        {
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
        }

        private void Converter_Base(int baseorigem, int basedestino)
        {
            long resParcial;
            int qtdCaracteres, aux2, restoMod;
            string caracteres = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ", numDigitado, resFinal, aux, baseValida;
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

