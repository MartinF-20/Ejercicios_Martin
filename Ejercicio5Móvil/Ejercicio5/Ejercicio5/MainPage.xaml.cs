using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio5
{
    public partial class MainPage : ContentPage
    {
        int contador;
        string _filname = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notas.txt");
        public MainPage()
        {
            InitializeComponent();
            contador = 0;
            if (File.Exists(_filname))
            {
                entrada.Text = File.ReadAllText(_filname);
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //contador++;
            //((Button)sender).Text = "Presionado!!! " + contador + " veces";
            File.WriteAllText(_filname, entrada.Text);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (File.Exists(_filname))
            {
                File.Delete(_filname);
            }
            entrada.Text = String.Empty;
        }
    }
}