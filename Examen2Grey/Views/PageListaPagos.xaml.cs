using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2Grey.Controllers;
using Examen2Grey.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen2Grey.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListaPagos : ContentPage
    {
        public PageListaPagos()
        {
            InitializeComponent();
        }

        

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listapagos.ItemsSource = await DataBase.ObtenerListaPagos();
        }

    }
}