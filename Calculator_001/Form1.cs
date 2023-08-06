using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;

namespace Calculator_001
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxVisor_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxVisor.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxVisor.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBoxVisor.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBoxVisor.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtBoxVisor.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtBoxVisor.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtBoxVisor.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtBoxVisor.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtBoxVisor.Text += "9";
        }
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            txtBoxVisor.Clear();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtBoxVisor.Text += "0";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            int count = txtBoxVisor.Text.Count(c => c == '÷');
            int countMais = txtBoxVisor.Text.Count(c => c == '+');
            int countMenos = txtBoxVisor.Text.Count(c => c == '-');
            int countDiv = txtBoxVisor.Text.Count(c => c == '×');

            if (count >= 1 || countMais >= 1 || countMenos == 1 || countDiv >= 1)
                txtBoxVisor.Text = txtBoxVisor.Text;

            else
                txtBoxVisor.Text += "×";
        }
        private void multiplicacao(string input)
        {
            string[] partes = input.Split('×');

            try
            {
                float n1 = float.Parse(partes[0]);
                float n2 = float.Parse(partes[1]);

                float result = n1 * n2;

                txtBoxVisor.Clear();
                txtBoxVisor.Text = result.ToString();
            }
            catch (FormatException)
            {
                txtBoxVisor.Text = txtBoxVisor.Text;
                return;
            }
        }
        // VERIFICAR ESSE MÉTODO
        private void buttonResult_Click(object sender, EventArgs e)
        {
            string input = txtBoxVisor.Text;

            if (txtBoxVisor.Text.Contains("+"))
                soma(input);

            else if (txtBoxVisor.Text.Contains("-"))
                subtracao(input);

            else if (txtBoxVisor.Text.Contains("÷"))
                divisao(input);
            
            else
                multiplicacao(input);

        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            int count = txtBoxVisor.Text.Count(c => c == '÷');
            int countMais = txtBoxVisor.Text.Count(c => c == '+');
            int countMenos = txtBoxVisor.Text.Count(c => c == '-');
            int countDiv = txtBoxVisor.Text.Count(c => c == '×');

            if (count >= 1 || countMais >= 1 || countMenos == 1 || countDiv >= 1)
                txtBoxVisor.Text = txtBoxVisor.Text;

            else
                txtBoxVisor.Text += "+";
        }

        private void soma(string input)
        {
            string[] partes = input.Split('+');

            try
            {
                float n1 = float.Parse(partes[0]);
                float n2 = float.Parse(partes[1]);

                float result = n1 + n2;

                txtBoxVisor.Clear();
                txtBoxVisor.Text = result.ToString();
            }
            catch (FormatException)
            {
                txtBoxVisor.Text = txtBoxVisor.Text;
                return;
            }
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            int count = txtBoxVisor.Text.Count(c => c == '÷');
            int countMais = txtBoxVisor.Text.Count(c => c == '+');
            int countMenos = txtBoxVisor.Text.Count(c => c == '-');
            int countDiv = txtBoxVisor.Text.Count(c => c == '×');

            if (count >= 1 || countMais >= 1 || countMenos == 1 || countDiv >= 1)
                txtBoxVisor.Text = txtBoxVisor.Text;

            else
                txtBoxVisor.Text += "-";

        }

        private void subtracao(string input)
        {
            string[] partes = input.Split('-');

            try
            {
                float n1 = float.Parse(partes[0]);
                float n2 = float.Parse(partes[1]);

                float result = n1 - n2;

                txtBoxVisor.Clear();
                txtBoxVisor.Text = result.ToString();
            }
            catch (FormatException)
            {
                txtBoxVisor.Text = txtBoxVisor.Text;
                return;
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            int count = txtBoxVisor.Text.Count(c => c == '÷');
            int countMais = txtBoxVisor.Text.Count(c => c == '+');
            int countMenos = txtBoxVisor.Text.Count(c => c == '-');
            int countDiv = txtBoxVisor.Text.Count(c => c == '×');

            if (count >= 1 || countMais >= 1 || countMenos == 1 || countDiv >= 1)
                txtBoxVisor.Text = txtBoxVisor.Text;

            else
                txtBoxVisor.Text += "÷";
        }

        private void divisao(string input)
        {
            string[] partes = input.Split('÷');

            try
            {
                float n1 = float.Parse(partes[0]);
                float n2 = float.Parse(partes[1]);

                float result = n1 / n2;

                txtBoxVisor.Clear();
                txtBoxVisor.Text = result.ToString();
            }
            catch (FormatException)
            {
                txtBoxVisor.Text = txtBoxVisor.Text;
                return;
            }
        }
    }
}