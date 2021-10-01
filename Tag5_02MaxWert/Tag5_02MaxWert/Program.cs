using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag5_02MaxWert
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            var x = 0.1;
            var a = 9.0;
            var b = a + 1;
            var c = a + b;
            double[] feld = {10.5,20,30};

            foreach (var value in feld)
            {
                Console.WriteLine(value);
            }
            
        }
    }
}
