using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Invoice
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public double NDS { get; set; }
        public Invoice(int iD, string date = "до 01.01.2000", string product, int count = 1, int price, int nDS = 20)
        {
            ID = iD;
            Date = date;
            Product = product;
            Count = count;
            Price = price;
            NDS = nDS;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID накладной: {ID}\n" +
                                $"Дата проведения накладной: {Date}\n" +
                                $"Наименование продукта: {Product}\n" +
                                $"Количество продукта: {Count}\n" +
                                $"Цена за единицу продукта: {Price}\n" +
                                $"НДС: {NDS}%");
        }
        public double GetFullPrice()
        {
            int price_without_nds = Price * Count;
            double nds = NDS / 100;
            double price_with_nds = price_without_nds + (nds * price_without_nds);
            return price_with_nds;
        }
    }
}
