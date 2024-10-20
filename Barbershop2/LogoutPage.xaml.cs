using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Barbershop2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LogoutPage : ContentPage
	{
		public LogoutPage ()
		{
			InitializeComponent ();
		}

        private async void LogoutButtonClicked(object sender, EventArgs e)
        {

            // Действия при нажатии кнопки "Выйти"
            await Navigation.PushAsync(new MainPage());

        }
        private async void CancelButtonClicked(object sender, EventArgs e)
        {

            // Действия при нажатии кнопки "Отмена"
            await Navigation.PushAsync(new FlyoutFlyoutPage());

        }
    }
}