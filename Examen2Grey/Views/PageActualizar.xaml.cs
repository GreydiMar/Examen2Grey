using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen2Grey.Models;
using Examen2Grey.Controllers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;
using System.IO;

namespace Examen2Grey.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageActualizar : ContentPage
    {
        Plugin.Media.Abstractions.MediaFile photo = null;
        public PageActualizar()
        {
            InitializeComponent();
        }

        private Byte[] traeImagenByteArray()
        {
            if (photo != null)
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    Stream stream = photo.GetStream();
                    stream.CopyTo(memory);
                    return memory.ToArray();
                }
            }
            return null;
        }

        private async void btnagregar_Clicked(object sender, EventArgs e)
        {
            if (photo == null)
                return;

            var Pagos = new Pagos
            {
                Id = Convert.ToInt32(Id.Text),
                Descripcion = descripcion.Text,
                Monto = Convert.ToDouble(monto.Text),
                Foto = traeImagenByteArray(),
                Fecha = fecha.Date,
            };
            await DataBase.AddPagos(Pagos);

            if (await DataBase.AddPagos(Pagos) > 0)
                await DisplayAlert("Aviso", "Pago Actualizado", "OK");
            else
                await DisplayAlert("Aviso", "ha ocurrido un error", "OK");
        }

        private async void btnfoto_Clicked(object sender, EventArgs e)
        {
            photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "FotosApp",
                Name = "test.jpg",
                SaveToAlbum = true
            });

            if (photo != null)
            {
                Foto.Source = ImageSource.FromStream(() =>
                {
                    return photo.GetStream();
                });
            }
        }
    }
}