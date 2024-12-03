using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    public static class CheckForEvenOrOdd
    {
     
        public static string EvenOdd(int i)
        {
            if (i % 2 == 0)
            {
                return ("The entered number is an Even Number");
                
            }
            else
            {
                return ("The entered number is an Odd Number");
                
            }
           }

    }
}
