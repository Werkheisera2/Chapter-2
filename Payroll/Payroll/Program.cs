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
            string input;
            int hours;
            double payRate;
            double Federal = 72.90;
            double State = 24.30;
            double net;
            
 
            Console.Write("pls enter ur name pls k thx: ");
            String name = Console.ReadLine();

            Console.Write("pls entr ur social secrty numbr pls thx: ");
            String Social = Console.ReadLine();

            //string first = Console.ReadLine();

            Console.Write("hey wut is ur hourly pay r8: ");
            input = Console.ReadLine();
            payRate = Convert.ToDouble(input);

            Console.Write("hey wt is ur hours worked pls tell me thx: ");
            input = Console.ReadLine();
            hours = Convert.ToInt32(input);
            Console.WriteLine("");


            double GrossPay = hours * payRate;

            net = GrossPay - State - Federal;

            Console.Write("You earned $" + hours + " at $" + payRate + " per hour.");
            Console.WriteLine("");
            Console.WriteLine("Gross Pay:                 " + GrossPay.ToString("C"));
            Console.WriteLine("Federal Witholding         " + Federal.ToString("C"));
            Console.WriteLine("State Witholding           " + State.ToString("C"));
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Net Pay:                   " + net.ToString("C"));

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            



        }
    }
}
