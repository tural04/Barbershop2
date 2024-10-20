using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Barbershop2
{
    // Определение класса страницы
    public partial class MainPage : ContentPage
    {
        // Конструктор класса
        public MainPage()
        {
            InitializeComponent();
        }
        // Обработчик события клика по кнопке
        private async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
  
                // Для считывания значения из элелементов ввода в переменные name, email, password
                string name = nameEntry.Text;
                string email = emailEntry.Text;
                string password = passwordEntry.Text;

            //Для сохранения данных в UserData.Instance
            UserData.Instance.Name = name;
            UserData.Instance.Email = email;
            UserData.Instance.Password = password;

            // Для отображения диалогового окна с сообщением об успешной регистрации
            await DisplayAlert("Успешно", "Вы зарегистрировались в приложении BarberMafia! Нажмите ОК, чтобы перейти в приложение", "ОК");

                var FlyoutPage = new FlyoutFlyoutPage();
            // Навигация на страницу FlyoutFlyoutPage
                await Navigation.PushAsync(new FlyoutFlyoutPage());
           
        }
    }
}

