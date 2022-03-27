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
            });

        }

        private void Ctr_MouseMove(object sender, MouseEventArgs e)
        {
            ctr = (Control)sender;
            if (down)
            {
                ctr.Left = e.X + ctr.Left - inicial.X;
                ctr.Top = e.Y + ctr.Top - inicial.Y;
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
    }
}
