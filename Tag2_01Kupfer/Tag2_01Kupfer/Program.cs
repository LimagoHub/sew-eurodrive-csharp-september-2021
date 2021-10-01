using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag2_01Kupfer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double aktuelleReserven=870;
            double aktuellerVerbrauch=24;
            double wachstumsrate;
            int anzahlJahre = 0;
            
            Console.WriteLine("Bitte geben Sie die Wachstumsrate ein: ");
            wachstumsrate = (Double.Parse(Console.ReadLine()) / 100.0) + 1.0;

            while (aktuelleReserven > 0)
            {
                aktuelleReserven -= aktuellerVerbrauch;
                aktuellerVerbrauch *=   wachstumsrate;
                //Console.WriteLine(aktuellerVerbrauch);
                anzahlJahre++;
            }
            
            Console.WriteLine(anzahlJahre);

        }
    }
}
