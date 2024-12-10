using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
/// Вывести название предмета по введенной первой букве: ф – физика, м – математика, 
/// и – история, г – география, б – биология
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string n = Vvod("n=");
            string x = GetName(n);
            Console.WriteLine(x);
            Console.ReadLine();
        }
        public static string Vvod(string message)
        {
            Console.Write(message);
            return (Console.ReadLine());
        }
        static string GetName(string letter) 
        {
            switch(letter.ToLower())
            {
                case "ф": return "Физика";
                case "м": return "Математика";
                case "и": return "История";
                case "г": return "География";
                case "б": return "Биология";
                default: return "Ошибка";
            }
        }
    }
}
