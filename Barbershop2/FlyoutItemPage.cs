using System;
using System.Collections.Generic;
using System.Text;

namespace Barbershop2
{
    //Класс страницы, определяющий элемент бокового меню
    class FlyoutItemPage
    {
        // Для получения заголовка элемента бокового меню
        public string Title { get; set; }
        //Для получения пути к иконке элемента бокового меню
        public string IconSource { get; set; }

        // Для хранения информации о том, какая страница должна быть показана
        public Type TargetPage { get; set; }
    }
}
