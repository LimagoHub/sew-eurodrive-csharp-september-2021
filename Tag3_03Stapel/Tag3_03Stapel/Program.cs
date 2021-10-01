using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using de.sew.csharpkurs;

namespace Tag3_03Stapel
{
    class Program
    {
        static void Main(string[] args)
        {
            Stapel myStapel = new Stapel();

            for (int i = 0; i < 10; i++)
            {
                if (!myStapel.IsFull)
                {
                    myStapel.Push(i);
                }
            }

            while (!myStapel.IsEmpty)
            {
                Console.WriteLine(myStapel.Pop());
            }

            myStapel.Pop();
        }
    }
}
