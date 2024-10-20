using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Barbershop2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // Определение главной страницы приложения
            MainPage = new NavigationPage(new MainPage());
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
