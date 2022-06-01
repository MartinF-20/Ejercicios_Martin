using Ejercicio4.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Ejercicio4.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}