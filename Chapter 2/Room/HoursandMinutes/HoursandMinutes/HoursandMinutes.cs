using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursandMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int Minutes = 185;
            Console.WriteLine("Worked 185 minutes. 185 minutes=" + Minutes / 60 + " hours and " + Minutes % 60+" minutes.");
        }
    }
}
