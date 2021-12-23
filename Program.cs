using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как Вас зовут? ");
            string name = Console.ReadLine();
            Console.Write("Сколько Вам лет? "); 
            string age = Console.ReadLine(); 
            Console.Write("Какая у Вас профессия? "); 
            string pro = Console.ReadLine(); 
            Console.Write("Какой Ваш знак зодиака? "); 
            string zodiak = Console.ReadLine(); 
            Console.WriteLine("Ваше имя " + name + ", Вам " + age + 
                " лет, Ваша профессия: " + pro + ", Ваш знак зодиака " + zodiak + ".");

        }
    }
}