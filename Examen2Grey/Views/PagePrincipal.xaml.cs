using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2Grey.Controllers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen2Grey.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private async void  ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagePagos());
        }

        private async void ToolDelePago_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageEliminarPagos());
        }

        private async void Toolupdatepago_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageActualizar());
        }

        private async void Toollista_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageListaPagos());
        }
    }
}