using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_26
{
    internal class CharacteristicCar
    {
        //Создать класс автомобиля для (гос номер, год выпуска, количество мест, стоимость аренды в сутки)

        #region Свойство
        public string Number { get; set; }
        public int Year { get; set; }
        public int NumberOfSeat { get; set; }
        public double Price { get; set; }
        public CarType Category { get; set; }
        public DateTime RentalsDate { get; set; }
        #endregion
        #region Конструктор
        public CharacteristicCar(string number, int year, int numberOfSeat, double price, CarType category, DateTime rentalsDate)
        {
            Number = number;
            Year = year;
            NumberOfSeat = numberOfSeat;
            Price = price;
            Category = category;
            Category = category;
            RentalsDate = rentalsDate;
        }
        #endregion
        public string GetInfo()
        {
            return $"Номер машину: {Number}:\nГод: {Year}\nКоличество мест: {NumberOfSeat}\nЦена: {Price}\n Категория: {Category}\n Дата аренды: {RentalsDate}\n";
        }

    }
    
}
