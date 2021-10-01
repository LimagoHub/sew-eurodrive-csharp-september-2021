using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using de.sew.collections;
using de.sew.tiere;

namespace Tag4_01KettenProjekt
{
    class Program
    {
        static void Main(string[] args)
        {

            //Liste liste = new Liste();
            //Schwein piggy = new Schwein("Miss Piggy"); //1000
            //liste.Append(piggy);


            //Schwein result = (Schwein) liste.Get();

            //Console.WriteLine(result.ToString());

            //liste.Remove();

            List<Schwein> schweine = new List<Schwein>();
            
            schweine.Add(new Schwein("Piggy"));
            schweine.Add(new Schwein("Babe"));
            schweine.Add(new Schwein("Rudi"));

            foreach (Schwein s in schweine)
            {
                Console.WriteLine(s);
            }


        }
    }
}
