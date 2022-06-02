using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Martin" && txtContraseña.Text == "12345")
            {
                Navigation.PushAsync(new Home());
            }
            else
            {
                DisplayAlert("Ops...","Nombre de usuario o contraseña incorrecto","Ok");
            }
        }
    }
}