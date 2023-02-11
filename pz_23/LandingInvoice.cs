using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class LandingInvoice:Invoice
    {
        public string CourierFIO { get; set; }
        public string MachineNumber { get; set; }
        public LandingInvoice(DateTime date, string product, int count, int price, double nDS, string name, string number)
        {
            Date = date;
            Product = product;
            Count = count;
            Price = price;
            NDS = nDS;
            CourierFIO = name;
            MachineNumber = number;
        }
        public LandingInvoice(string name, string number):base()
        {
            CourierFIO = name;
            MachineNumber = number;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"ФИО курьера: {CourierFIO}\n" +
                                $"Гос. номер машины курьера: {MachineNumber}");
            base.PrintInfo();
            
        }
    }
}
