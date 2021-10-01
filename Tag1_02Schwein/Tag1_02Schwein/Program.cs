using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_02Schwein
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            
           
          
            Schwein piggy = new Schwein(); // new immer auf freien Heap


            piggy.Name = "Elsa";
            
            Console.WriteLine(piggy.ToString());

            for (int i = 0; i < 15; i++)
            {
                piggy.fressen();
                Console.WriteLine(piggy.ToString());
            }

            Object objectreferenz = piggy;
            Console.WriteLine(objectreferenz.ToString());
          


        }
    }
}
