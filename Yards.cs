using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25;
            int width = 42;
            double money = 3.25;
            Console.WriteLine("The length of the carpet is " + length + " feet long.");
            Console.WriteLine("");
            Console.WriteLine("The width of the carpet is " + width + " feet long.");
            Console.WriteLine("");
            Console.WriteLine("The cost of carpeting per sqare yard is $" + money + ".");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Length of carpet:                          " + length + " feet");
            Console.WriteLine("Width of carpet:                           " + width + " feet");
            Console.WriteLine("Cost of carpeting (in square yards)        $" + money);
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("Carpeting this room costs:                 $" + length * width / 9 * 3.25);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            String input;
            int total;

            Console.Write("Did you enjoy your experience? ");
            input=Console.ReadLine();
        }
    }
}
