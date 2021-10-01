using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag3_07Nummspiel
{
    public class Nimmspiel
    {

        private int steine;


        private bool Spielende
        {
            get { return steine < 1;  }
        }
        
        public Nimmspiel()
        {
            steine = 23;
        }

        public void play()
        {
            while (!Spielende)
            {
                Spielerzug();
                Computerzug();
            }
        }

       
        private void Spielerzug()
        {
            int zug;
            while (true)
            {
                Console.WriteLine("Es gibt {0} Steine. Bitte nehmen Sie 1, 2 oder 3", steine);
                zug = int.Parse(Console.ReadLine());
                if (zug >= 1 && zug <= 3) break;
                Console.WriteLine("Ungueltiger Zug");
            }

            steine -= zug;
        }
        private void Computerzug()
        {
            if (checkLosing()) return;
            
            
            int[] zuege = {3, 1, 1, 2};
            int zug;
   

            zug = zuege[steine % 4];
            Console.WriteLine("Computer nimmt {0} Steine.", zug);
            steine -= zug;

        }

        private bool checkLosing()
        {
            if (Spielende)
            {
                Console.WriteLine("Du Loser");
                return true;
            }

            if (steine == 1)
            {
                Console.WriteLine("Du hast nur Glueck gehabt");
                steine = 0;
                return true;
            }

            return false;
        }
    }
}
