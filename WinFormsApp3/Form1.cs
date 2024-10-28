using System.Linq.Expressions;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
            Potenciacao,
            Radiciacao,
            Potencia2,
            RaizQuadrada,
            Seno,
            Cosseno,
            Tangente
        }


        public Form1()
        {
            InitializeComponent();

        }
        

        private void botao0_Click(object sender, EventArgs e)
        {
            richBox1.Text += "0";

        }

        private void botao1_Click(object sender, EventArgs e)
        {
            richBox1.Text += "1";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            richBox1.Text += "2";

        }

        private void botao3_Click(object sender, EventArgs e)
        {
            richBox1.Text += "3";

        }

        private void botao4_Click(object sender, EventArgs e)
        {
            richBox1.Text += "4";

        }

        private void botao5_Click(object sender, EventArgs e)
        {
            richBox1.Text += "5";

        }

        private void botao6_Click(object sender, EventArgs e)
        {
            richBox1.Text += "6";

        }

        private void botao7_Click(object sender, EventArgs e)
        {
            richBox1.Text += "7";

        }

        private void botao8_Click(object sender, EventArgs e)
        {
            richBox1.Text += "8";

        }

        private void botao9_Click(object sender, EventArgs e)
        {
            richBox1.Text += "9";

        }

        private void botaoMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(richBox1.Text);
            richBox1.Text = "";
            Lbl1.Text = "-";

        }

        private void botaoMais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(richBox1.Text);
            richBox1.Text = "";
            Lbl1.Text = "+";

        }

        private void botaoVezes_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(richBox1.Text);
            richBox1.Text = "";
            Lbl1.Text = "*";
        }

        private void botaoDividir_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(richBox1.Text);
            richBox1.Text = "";
            Lbl1.Text = "/";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            decimal novoValor = 0;
            if (richBox1.Text != "")
            {
                novoValor = Convert.ToDecimal(richBox1.Text);
            }

            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + novoValor;
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - novoValor;
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * novoValor;
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / novoValor;
                    break;
                case Operacao.Potenciacao:
                    Resultado = (decimal)Math.Pow((double)Valor, (double)novoValor);
                    break;
                case Operacao.Radiciacao:
                    Resultado = (decimal)Math.Pow((double)Valor, 1.0 / (double)novoValor);
                    break;
                case Operacao.Potencia2:
                    Resultado = Valor * Valor;
                    break;
                case Operacao.RaizQuadrada:
                    Resultado = (decimal)Math.Sqrt((double)Valor);
                    break;
                case Operacao.Seno:
                    Resultado = (decimal)Math.Sin((double)Valor * Math.PI / 180.0);
                    break;
                case Operacao.Cosseno:
                    Resultado = (decimal)Math.Cos((double)Valor * Math.PI / 180.0);
                    break;
                case Operacao.Tangente:
                    Resultado = (decimal)Math.Tan((double)Valor * Math.PI / 180.0);
                    break;

            }
            richBox1.Text = Convert.ToString(Resultado);
            Lbl1.Text = "=";
        }

        private void Virgula_Click(object sender, EventArgs e)
        {
            if (!richBox1.Text.Contains(","))
                richBox1.Text += ",";
        }

        private void botaoC_Click(object sender, EventArgs e)
        {
            richBox1.Text = "";
            Lbl1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void botaoCE_Click(object sender, EventArgs e)
        {
            if (richBox1.Text.Length > 0)
            {
                richBox1.Text = richBox1.Text.Remove(richBox1.Text.Length - 1);
            }
        }

        private void botaoPotencia_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Potenciacao;
            Valor = Convert.ToDecimal(richBox1.Text);
            richBox1.Text = "";
            Lbl1.Text = "^";
        }

        private void botaoRadiciacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Radiciacao;
            Valor = Convert.ToDecimal(richBox1.Text);
            richBox1.Text = "";
            Lbl1.Text = "y√x";
        }

        private void botaoPotencia2_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Potencia2;
            decimal valor = Convert.ToDecimal(richBox1.Text);
            Resultado = valor * valor;
            richBox1.Text = Convert.ToString(Resultado);
            Lbl1.Text = "x²";
        }

        private void RaizQuadrada_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDecimal(richBox1.Text);
            Resultado = (decimal)Math.Sqrt((double)Valor);
            richBox1.Text = Convert.ToString(Resultado);
            Lbl1.Text = "²√x";
        }

        private void botaoSIN_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Seno;
            Valor = Convert.ToDecimal(richBox1.Text);

            double radianos = (double)Valor * Math.PI / 180.0;

            switch (OperacaoSelecionada)
            {
                case Operacao.Seno:
                    Resultado = (decimal)Math.Sin(radianos);
                    break;
            }

            richBox1.Text = Convert.ToString(Resultado);
            Lbl1.Text = "=";
        }

        private void botaoCOS_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Cosseno;
            Valor = Convert.ToDecimal(richBox1.Text);

            switch (OperacaoSelecionada)
            {
                case Operacao.Cosseno:
                    Resultado = (decimal)Math.Cos((double)Valor * Math.PI / 180.0);
                    break;
            }

            richBox1.Text = Convert.ToString(Resultado);
            Lbl1.Text = "=";
        }

       

        private void botaoMS_Click(object sender, EventArgs e)
        {
            
        }

        private void botaoTAN_Click_1(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Tangente;
            Valor = Convert.ToDecimal(richBox1.Text);

            switch (OperacaoSelecionada)
            {
                case Operacao.Tangente:
                    Resultado = (decimal)Math.Tan((double)Valor * Math.PI / 180.0);
                    break;
            }

            richBox1.Text = Convert.ToString(Resultado);
            Lbl1.Text = "=";
        }
    }


}
