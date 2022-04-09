using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Examen2Grey.Controllers;
using Examen2Grey.Views;
using System.IO;
namespace Examen2Grey
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DataBase.Conexion(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DBPR.db3"));
            MainPage = new NavigationPage(new PageInicio());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
