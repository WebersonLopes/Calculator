using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "") { 
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            txtresultado.Text = "";
            lbltext.Text = "+";
            operacao = "Soma";
            }
            else
            {
                MessageBox.Show("Primeiro digite um número.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "5";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "6";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtresultado.Text += ".";
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "") { 
            valor2 = decimal.Parse(txtresultado.Text);
            if (operacao == "Soma")
            {
                txtresultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "Sub")
            {
                txtresultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if(operacao == "Div")
            {
                txtresultado.Text = Convert.ToString(valor1 / valor2);
            }
            else if(operacao == "Mult")
            {
                txtresultado.Text = Convert.ToString(valor1 * valor2);
            }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "") { 
            valor1 = decimal.Parse(txtresultado.Text,CultureInfo.InvariantCulture);
            txtresultado.Text = "";
            lbloperacao.Text = "-";
            operacao = "Sub";
            }
            else
            {
                MessageBox.Show("Primeiro digite um número a ser subtraido.");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "") { 
            valor1 = decimal.Parse(txtresultado.Text,CultureInfo.InvariantCulture);
            txtresultado.Text = "";
            lbloperacao.Text = "X";
            operacao = "Mult";
            }
            else
            {
                MessageBox.Show("Primeiro digite um número.");
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "") { 
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            txtresultado.Text = "";
            lbloperacao.Text = "/";
            operacao = "Div";
            }
            else
            {
                MessageBox.Show("Primeiro digite um número.");
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
            lbloperacao.Text = "";
            lbltext.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "9";
        }
    }
}
