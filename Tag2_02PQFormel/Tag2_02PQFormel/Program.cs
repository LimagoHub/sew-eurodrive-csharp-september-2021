using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag2_02PQFormel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // x1/2 = -p/2 * wurzel(phoch2 / 4 -q)
            
            double p;
            double q;

            double x1, x2;

            double minusPHalbe;
            double diskriminate;

            Console.WriteLine("Bitte Wert für P eingeben:");
            p = Double.Parse(Console.ReadLine());

            Console.WriteLine("Bitte Wert für Q eingeben:");
            q = Double.Parse(Console.ReadLine());

            minusPHalbe = -p / 2.0;
            diskriminate = minusPHalbe * minusPHalbe - q;

            if (diskriminate < 0)
            {
                Console.WriteLine("Keine Nullstelle gefunden.");
            }
            else if (diskriminate == 0)
            {
                Console.WriteLine("Eine Nullstelle gefunden.");
                Console.WriteLine("x = {0}", minusPHalbe);
            }
            else
            {
                Console.WriteLine("Zwei Nullstellen gefunden.");
                x1 = minusPHalbe + Math.Sqrt(diskriminate);
                x2 = minusPHalbe - Math.Sqrt(diskriminate);
                Console.WriteLine("x1 = {0}, x2 = {1}",x1,x2);
            }

        }
    }
}
