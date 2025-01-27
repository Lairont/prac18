using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Задание 2. Создать класс с именем Address. В теле класса требуется создать поля: index, country, city, street, house, apartаment.
    /// Создать экземпляр класса Address.В поля экземпляра записать информацию о почтовом адресе.
    ///  Выведите на экран значения полей, описывающих адрес.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "2000";
            address.Country = "Молдова";
            address.City = "Кишинёв";
            address.Street = "Бульвар Гагарина";
            address.House = 757;
            address.Apartment = 56;
            address.AddressInfo();
            Console.ReadLine();
        }
    }
}
