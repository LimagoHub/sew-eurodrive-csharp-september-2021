using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag2_06Geometrie
{
    public class Punkt
    {
        private readonly double MAX = 10.0;
        private double x;
        private double y;

        public Punkt()
        {
            x = y = 0;
        }

        public double X
        {
            get { return x; }
            private set
            {
                if (value < -MAX)
                {
                    value = -MAX;
                }
                if (value > MAX)
                {
                    value = MAX;
                }

                x = value;
            }
        }
        public double Y
        {
            get { return y; }
            private set
            {
                if (value < -MAX)
                {
                    value = -MAX;
                }
                if (value > MAX)
                {
                    value = MAX;
                }

                y = value;
            }
        }

        public string ToString()
        {
            return "Punkt: X=" + X + ", Y=" + Y;
        }

        // public void Rechts()
        // {
        //     X++;
        // }
        public void Rechts(double offset = 1) // Überladen
        {
            X+=offset;
        }
        public void Links()
        {
            X--;
        }
        public void Oben()
        {
            Y++;
        }
        public void Unten()
        {
            Y--;
        }

    }
}
