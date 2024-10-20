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
	public partial class PersonalPage : ContentPage
	{
		public PersonalPage ()
		{
			InitializeComponent ();

            // Инициализация текстовых меток данными из UserData.Instance
            nameLabel.Text = $"Имя: {UserData.Instance.Name}";
            emailLabel.Text = $"Почта: {UserData.Instance.Email}";
            passwordLabel.Text = $"Пароль: {UserData.Instance.Password}";
        }
	}
}