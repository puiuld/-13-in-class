using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Vvod("day= ");
            string x = GetName(n);
            Console.WriteLine(x);
            Console.ReadLine();
        }

        public static int Vvod(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static string GetName(int day)
        {
            switch (day)
            {
                case 1:return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default:return "Ошибка";
                        
            }
        }



    }   
}
