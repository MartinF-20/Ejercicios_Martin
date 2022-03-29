using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form1 : Form
    {
        bool down = false;
        Point inicial;
        Control ctr;

        public Form1()
        {
            InitializeComponent();
            this.Controls.OfType<Control>().Where(ctrl => ctrl is Label).ToList().ForEach(ctrl =>
            {
                ctrl.MouseDown += Ctr_MouseDown;
                ctrl.MouseUp += Ctr_MouseUp;
                ctrl.MouseMove += Ctr_MouseMove;
                validar();
            });
    

        }

        private void Ctr_MouseMove(object sender, MouseEventArgs e)
        {
            ctr = (Control)sender;
            if (down)
            {
                ctr.Left = e.X + ctr.Left - inicial.X;
                ctr.Top = e.Y + ctr.Top - inicial.Y;
                if (element1.Location.X >= 100 && element1.Location.X <= 500 && element1.Location.Y >= 50 && element1.Location.Y <= 450)
                {
                    
                }
                else
                {
                    element1.SetBounds(711, 168, 30, 30);
                }

                if (element2.Location.X >= 100 && element2.Location.X <= 500 && element2.Location.Y >= 50 && element2.Location.Y <= 450)
                {

                }
                else
                {
                    element2.SetBounds(761, 168, 30, 30);
                }

                if (element3.Location.X >= 100 && element3.Location.X <= 500 && element3.Location.Y >= 50 && element3.Location.Y <= 450)
                {

                }
                else
                {
                    element3.SetBounds(711, 215, 30, 30);
                }

                if (element4.Location.X >= 100 && element4.Location.X <= 500 && element4.Location.Y >= 50 && element4.Location.Y <= 450)
                {

                }
                else
                {
                    element4.SetBounds(761, 215, 30, 30);
                }
            }
        }

        private void Ctr_MouseUp(object sender, MouseEventArgs e) => down = false;

        private void Ctr_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                down = true;
                inicial = e.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void reiniciar()
        {
            element1.SetBounds(711, 168, 30, 30);
            element2.SetBounds(761, 168, 30, 30);
            element3.SetBounds(711, 215, 30, 30);
            element4.SetBounds(761, 215, 30, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reiniciar();
        }

        private void validar()
        {

        }

        private void element1_Click(object sender, EventArgs e)
        {

        }

        private void element2_Click(object sender, EventArgs e)
        {

        }

        private void element3_Click(object sender, EventArgs e)
        {

        }

        private void element4_Click(object sender, EventArgs e)
        {

        }

        private void p1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
