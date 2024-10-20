using Barbershop2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace Barbershop2
{
	public partial class BarberRegistrPage : ContentPage
	{

        public BarberRegistrPage ()
		{
			InitializeComponent ();
        }
        
        private void BarberservicesButtonClicked(object sender, EventArgs e)
        {
            // Обработчик нажатия на кнопку "Записаться"
            string barber = barberPicker.SelectedItem.ToString();
            string services = servicesPicker.SelectedItem.ToString();
            string addservices = addservicesPicker.SelectedItem.ToString();
            DateTime dateTime = datePicker.Date + timePicker.Time;

            // Вплывающее окно с сообщением
            DisplayAlert("Готово!", "Вы успешно записались к барберу!", "OK");

        }
    }
}
