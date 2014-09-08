using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Room
{
    class Program
    {
        static void Main(string[] args)
        {
            int Length = 25;
            int Width = 10;
            Console.WriteLine("Length:             25 feet");
            Console.WriteLine("Width:              10 feet");
            Console.WriteLine("___________________________");
            Console.WriteLine("The floor space is " + Length * Width);
            Console.WriteLine("square feet.");
        }
    }
}
