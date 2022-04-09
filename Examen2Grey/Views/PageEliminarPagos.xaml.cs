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
    public partial class PageEliminarPagos : ContentPage
    {
        public PageEliminarPagos()
        {
            InitializeComponent();
        }

       
        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            var pagos = new Pagos
            {
                Id = Convert.ToInt32(id.Text),
            };

            await DataBase.DelPagos(pagos);
        }
    }
}