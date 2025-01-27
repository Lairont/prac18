using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Задание 1. Создать класс Person с полями: имя, фамилия, возраст и методом вывода всех данных на консоль.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Никита";
            person.LastName = "Банчу";
            person.Age = 17;
            person.Info();
            Console.ReadLine();
        }
    }
}
