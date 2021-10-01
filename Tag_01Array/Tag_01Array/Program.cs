using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag_01Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Schwein piggy;     // (zeiger) enthält die Adresse und Metainformation 32-bit
            // piggy = new Schwein(); // Instanziierung
            //
            // piggy.Name = "Miss Piggy";
            // Console.WriteLine(piggy.ToString());
            // piggy.fressen();
            // Console.WriteLine(piggy.ToString());


            double x; // Skalar (Schublade)

            double[] anderesArray = {3.1, -4.5, 8};
            
            double [] feld; // Array- bzw. Feld Zeiger; 32-bit

            feld = new double[3];
            feld[0] = 3.14; //feld (2000) + 0 mal sizeof(double)
            feld[1] = 1.41; // feld (2000) + 1 mal sizeof(double)
            feld[2] = 3.0; // feld (2000) + 2 mal sizeof(double)
            
            
            for(int i = 0; i < feld.Length; i++)
            {
                Console.WriteLine(feld[i]);
            }

            Console.WriteLine("-----------------");
            foreach ( double value in feld)
            {
                Console.WriteLine(value);
            }


            Schwein [] stall; // 32-bit

            stall = new Schwein[10];

            for (int i = 0; i < stall.Length; i++)
            {
                stall[i] = new Schwein();
            }


        }

    }
    
   
}
