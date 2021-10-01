using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag2_04Monster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Monster zombie = new Monster();

            zombie.Size = -100;

            zombie.Eat();
            zombie.MakeNoise();
            
            Console.WriteLine(zombie.Size);
        }
    }
}
