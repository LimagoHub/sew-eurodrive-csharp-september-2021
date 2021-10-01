using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag2_03Kreis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bitte Radius eingeben:");
            double radius = Double.Parse(Console.ReadLine());

            double umfang = 2 * Math.PI * radius;
            double flaeche = Math.PI * radius * radius;

            Console.WriteLine("Umfang = {0}, Flaeche = {1}", umfang, flaeche);

        }
    }
}
