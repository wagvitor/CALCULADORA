using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        //variáveis
        int OP;
        double v1, v2;
        public Form1()
        {
            InitializeComponent();
        }

        private void painel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtValor.Text += "1";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtValor.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtValor.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtValor.Text += "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtValor.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtValor.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtValor.Text += "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtValor.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtValor.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtValor.Text += "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OP = 1;
            v1 = Convert.ToDouble(txtValor.Text);
            txtValor.Clear();



        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
        }

        private void subtrair_Click(object sender, EventArgs e)
        {
            OP = 2;
            v1 = Convert.ToDouble(txtValor.Text);
            txtValor.Clear();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            OP = 3;
            v1 = Convert.ToDouble(txtValor.Text);
            txtValor.Clear();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            OP = 4;
            v1 = Convert.ToDouble(txtValor.Text);
            txtValor.Clear();
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            double result;

            v2 = Convert.ToDouble(txtValor.Text);
            txtValor.Clear();


            switch (OP)
            {
                case 1:
                    result = v1 + v2;
                    txtValor.Text = result.ToString();
                    break;
                case 2:
                    result = v1 - v2;
                    txtValor.Text = result.ToString();
                    break;
                default:
                    break;
                case 3:
                    result = v1 * v2;
                    txtValor.Text = result.ToString();
                    break;
                case 4:
                    result = v1 / v2;
                    txtValor.Text = result.ToString();
                    break;
            }




        }
    }

    //private void button10_Click(object sender, EventArgs e)

}


