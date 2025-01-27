using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Address
    {
        public string Index;
        public string Country;
        public string City;
        public string Street;
        public int House;
        public int Apartment;
        public void AddressInfo()
        {
            Console.WriteLine($"Почтовый индекс: {Index}");
            Console.WriteLine($"Страна: {Country}");
            Console.WriteLine($"Город: {City}");
            Console.WriteLine($"Улица: {Street}");
            Console.WriteLine($"Дом: {House}");
            Console.WriteLine($"Квартира: {Apartment}");
        }
    }
}
