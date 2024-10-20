using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Barbershop2
{
    public partial class FlyoutFlyoutPage : FlyoutPage
    {
        // Конструктор класса
        public FlyoutFlyoutPage()
        {
            InitializeComponent();
            //Привязывает обработчик события к событию выбора элемента в боковом меню
            flyout.listview.ItemSelected += OnSelectedItem;
        }

        // Обработчик события выбора элемента в боковом меню
        private void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as FlyoutItemPage;
            if (item!= null)
            {
                // Считывает выбранный элемент и открывает страницу
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetPage));
                flyout.listview.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}