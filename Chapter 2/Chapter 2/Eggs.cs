using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Chicken1 = 20;
            int Chicken2 = 25;
            int Hen = 15;
            int Rooster = 31;
            int Sum = Chicken1 + Chicken2 + Hen + Rooster;

            Console.WriteLine("Chicken1 had 20 eggs. Chicken 2 had 25 eggs, Hen had 15 eggs, and Rooster had 31 eggs");
            Console.WriteLine("There are " + Sum + " eggs in all.");
            Console.WriteLine("In other words, there "+Sum/12+" dozens, and "+Sum%12+" eggs in all");
        }
    }
}
