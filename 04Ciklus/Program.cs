using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Ciklus
{
    /// <summary>
    /// Írjunk egy olyan programot, ami a bujócskában elszámol 10-ig
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");
            Console.WriteLine();


            //De mi van akkor, ha 100-ig kell eszámolni?
            //vagy 10.000-ig?

            //háromféle ciklus: while, for és foreach

            //az "i" a ciklusváltozó

            for (int i = 1; i <= 100; i++)  //i++ ugyanaz, mint ez: i = i + 1;
            { //ez itt a ciklus törzse
                System.Threading.Thread.Sleep(500); //A programunk vár fél másodpercet
                Console.WriteLine(i);
            }

            Console.ReadLine();

        }
    }
}
