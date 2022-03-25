using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox1 = (TextBox)sender;

            if (textBox1.Text.Length <= 0) return;
            bool isRight = Double.TryParse(textBox1.Text, out _);

            if (!isRight)
            {
                MessageBox.Show("Dato no válido");
                String res = "";
                for (int i = 0; i < textBox1.TextLength; i++)
                {
                    switch (textBox1.Text[i])
                    {
                        case '.':
                        case '0':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                            res += textBox1.Text[i];
                            break;
                    }
                    

                    if(textBox1.Text[i] >= '0' && textBox1.Text[i] <= '9')
                    {
                        res += textBox1.Text[i];
                    }
                }
            }

            //char last = textBox1.Text[textBox1.Text.Length - 1];
            /*if (!(last >= '0' && last <= '9'))
            {
                MessageBox.Show("Datos no validos");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }*/
        }

        private void aceptar_Click(object sender, EventArgs e)
        {

        }

        private void igual_Click(object sender, EventArgs e)
        {
            //DialogResult.AppendText(total.ToString());
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !(e.KeyChar=='.'))
            {
                e.Handled = false;
            }
        }
    }
}
