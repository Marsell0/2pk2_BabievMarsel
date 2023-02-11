using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class Invoice
    {
        private DateTime _date;
        static int id_counter = 1;
        public int ID { get; set; } = id_counter; // убрал пользователю возможность устанвливать id через конструктор, чтобы использовать статический метод
        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value.CompareTo(DateTime.Today) >= 0)
                {
                    _date = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Действие данной накладной закончилось. Установлена текущая дата.");
                    _date = DateTime.Now;
                }
            }
        }
        public string Product { get; set; } = $"Продукт №{id_counter}";
        public int Count { get; set; } = 1;
        public int Price { get; set; } = 100;
        public double NDS { get; set; } = 0.2;
        public Invoice(DateTime date, string product, int count, int price, double nDS)
        {
            Date = date;
            Product = product;
            Count = count;
            Price = price;
            NDS = nDS;
            id_counter += 1;
        }
        public Invoice()
        {
            Date = DateTime.Now;
            id_counter += 1;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"ID накладной: {ID}\n" +
                                $"Дата окончания накладной: {Date}\n" +
                                $"Наименование продукта: {Product}\n" +
                                $"Количество продукта: {Count}\n" +
                                $"Цена за единицу продукта: {Price}\n" +
                                $"НДС: {NDS * 100}%");
        }
        public double GetFullPrice()
        {
            int price_without_nds = Price * Count;
            double price_with_nds = price_without_nds + (NDS * price_without_nds);
            return price_with_nds;
        }
    }
}
