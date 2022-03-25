using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        double resultado;
        int num1;
        int num2;
        string operador;

        public Form1()
        {
            InitializeComponent();
            resultado = 0;
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public String hacerOperacion(String operador, int n1, int n2)
        {
            switch (operador)
            {
                // Caso de suma, suma el valor de n1 con el valor de n2
                case "+":
                    resultado = n1 + n2;
                    return resultado.ToString() + "";
                // Caso de resta, resta el valor de n2 al valor de n1
                case "-":
                    var resta = n1 - n2;
                    return resta.ToString() + "";
                // Caso de division, verifica primero que los numeros sean mayores a 0 y despues divide el valor de n1 entre el valor de n2
                case "/":
                    if (n1 > 0)
                    {
                        int division = n1 / n2;
                        return division.ToString() + "";
                    }
                    else
                    {
                        return "No se puede dividir entre 0";
                    }
                // Caso de multiplicacion, multiplica el valor de n1 por el de n2
                case "*":
                    var multiplicacion = n1 * n2;
                    return multiplicacion.ToString() + "";
                // Caso de elevacion, eleva el valor de n1 con el valor de n2
                case "^":
                    if (n1 != 0)
                    {
                        var elevar = Math.Pow(n1, n2);
                        return elevar.ToString() + "";
                    }
                    break;
                default:
                    return "";
            }
            return null;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (text.Text.Length > 20)
            {
                MessageBox.Show("Desbordamiento de memoria");
            }
            else
            {
                text.ForeColor = Color.Black;
                text.AppendText("1");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(text.Text.Length > 20)
            {
                MessageBox.Show("Desbordamiento de memoria");
            }
            else
            {
                text.ForeColor = Color.Black;
                text.AppendText("2");
            }
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (text.Text.Length > 20)
            {
                MessageBox.Show("Desbordamiento de memoria");
            }
            else
            {
                text.ForeColor = Color.Black;
                text.AppendText("3");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (text.Text.Length > 20)
            {
                MessageBox.Show("Desbordamiento de memoria");
            }
            else
            {
                text.ForeColor = Color.Black;
                text.AppendText("4");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (text.Text.Length > 20)
            {
                MessageBox.Show("Desbordamiento de memoria");
            }
            else
            {
                text.ForeColor = Color.Black;
                text.AppendText("5");
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (text.Text.Length > 20)
            {
                MessageBox.Show("Desbordamiento de memoria");
            }
            else
            {
                text.ForeColor = Color.Black;
                text.AppendText("6");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (text.Text.Length > 20)
            {
                MessageBox.Show("Desbordamiento de memoria");
            }
            else
            {
                text.ForeColor = Color.Black;
                text.AppendText("7");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (text.Text.Length > 20)
            {
                MessageBox.Show("Desbordamiento de memoria");
            }
            else
            {
                text.ForeColor = Color.Black;
                text.AppendText("8");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (text.Text.Length > 20)
            {
                MessageBox.Show("Desbordamiento de memoria");
            }
            else
            {
                text.ForeColor = Color.Black;
                text.AppendText("9");
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (text.Text.Length > 20)
            {
                MessageBox.Show("Desbordamiento de memoria");
            }
            else
            {
                text.ForeColor = Color.Black;
                text.AppendText("0");
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            text.ForeColor = Color.Black;
            operador = "+";
            var r = int.TryParse(text.Text, out int temporal);
            text.Text = "";
            num1 = temporal;

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            text.ForeColor = Color.Black;
            operador = "-";
            var r = int.TryParse(text.Text, out int temporal);
            text.Text = "";
            num1 = temporal;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            text.ForeColor = Color.Black;
            operador = "/";
            var r = int.TryParse(text.Text, out int temporal);
            text.Text = "";
            num1 = temporal;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            text.ForeColor = Color.Black;
            operador = "*";
            var r = int.TryParse(text.Text, out int temporal);
            text.Text = "";
            num1 = temporal;
        }

        private void btnElevar_Click(object sender, EventArgs e)
        {
            text.ForeColor = Color.Black;
            operador = "^";
            var r = int.TryParse(text.Text, out int temporal);
            text.Text = "";
            num1 = temporal;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            var r = int.TryParse(text.Text, out int temporal);
            text.Text = "";
            num2 = temporal;
            text.AppendText(hacerOperacion(operador, num1, num2).ToString());
        }
    }
}