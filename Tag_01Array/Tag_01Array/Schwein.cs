using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag_01Array
{
    public class Schwein
    {
        private string name;
        private int gewicht;

        public Schwein()
        {
            name = "Nobody";
            gewicht = 10;
        }

        public string Name {
            get
            {
                return name;
            }
            set
            {
                if (value != "Elsa")
                    name = value;
            }
        }

        public int Gewicht
        {
            get { return gewicht; }
            private set { gewicht = value; }
        }

        public void fressen()
        {
            Gewicht++;
        }

        public override string ToString()
        {
            return "Schwein: Name=" + Name + ", Gewicht=" + Gewicht;
        }
    }
}
