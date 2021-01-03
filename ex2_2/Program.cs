using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit.*/
namespace ex2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводи любой текс, пока не надоест. Для выхода из игры напечатай слово exit\n");
            string forExit = "exit";
            string myInput = "";
            while (forExit!= myInput)
            {
                Console.Write("Вводи слово... ");
                myInput = Console.ReadLine();
            }
            Console.WriteLine("Валим!");
            Console.ReadLine();
        }
    }
}