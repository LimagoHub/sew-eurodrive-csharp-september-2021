using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_02Schwein
{
    public class Schwein
    {
        private string name;
        private int gewicht;

        public int Gewicht
        {
            get { return gewicht; }
            private set
            {
                if (value < 10)
                    value = 10;

                if (value > 20)
                    value = 20;
                
                gewicht = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value != "Elsa")
                {
                    name = value;
                }
            }
        }
        


        // public void SetGewicht(int neueGewicht)
        // {
        //     
        //     gewicht = neueGewicht;
        // }    
        //
        
    // Konstruktor
        public Schwein()
        {
            Name = "nobody";
            gewicht = 10;
        }

        public void fressen()
        {
            Gewicht++;
        }

        public string ToString()
        {
            return "Schwein: Name = " + Name + ", Gewicht = " + Gewicht;
        }
    }
}
