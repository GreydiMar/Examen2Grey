using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen2Grey.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageInicio : ContentPage
    {
        public PageInicio()
        {
            InitializeComponent();
        }

        private async void btn_pagos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagePrincipal());
        }
    }
}