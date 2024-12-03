using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EvenOrOddConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            Console.Write("Please enter an Integer: ");
            i = int.Parse(Console.ReadLine());
            string output = EvenOrOdd.CheckForEvenOrOdd.EvenOdd(i);
            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}
