using System;
using System.Collections.Generic;
using System.Text;

namespace Barbershop2
{
    // Определяет класс для хранения данных пользователя
    internal class UserData
    {
        private static UserData _instance;

        //Свойства для хранения данных пользователя
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private UserData() { }
        
        // Для получения единственного экземпляра класса
        public static UserData Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserData();
                return _instance;
            }
        }
    }
}


