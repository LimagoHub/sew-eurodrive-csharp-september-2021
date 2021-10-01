using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag2_07Unterprogramme
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben sie ihren Nettobetrag ein ");
            double Nettobetrag = double.Parse(Console.ReadLine());
            double Bruttobetrag = BruttobetragBerechnen(Nettobetrag);

            Console.WriteLine(Bruttobetrag);
        }
        public static double BruttobetragBerechnen(double Nettobetrag)
        {
            double mwst = 1.19;
            double Bruttobetrag = Nettobetrag * mwst;
            if (Bruttobetrag > 1000)
            {
                Bruttobetrag = SkontoBerechnen(Bruttobetrag);
            }
            return Bruttobetrag;
        }
        public static double SkontoBerechnen(double Bruttobetrag)
        {
            return Bruttobetrag * 0.97;
        }
    }
}
