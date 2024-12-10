using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
/// По номеру месяца вывести название времени года.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = Vvod("n=");
            string x = GetName(n);
            Console.WriteLine(x);
            Console.ReadLine();
        }
        public static int Vvod(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static string GetName(int month)
        {
            switch(month)
            {
                
                case 12: case 1: case 2: return "Зима";
                case 3: case 4: case 5:return"Весна";
                case 6: case 7: case 8: return "Лето";
                case 9: case 10: case 11: return "Осень";
                default:return "Ошибка";
            }
        }
    }
}
