using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag2_06Geometrie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Punkt p = new Punkt();

            for (int i = 0; i < 12; i++)
            {
                //p.Rechts();
                p.Rechts(1.5);
                
                Console.WriteLine(p.ToString());
            }
            
            
            
        }
    }
}
