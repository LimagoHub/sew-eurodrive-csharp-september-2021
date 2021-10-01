using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag2_04Monster
{
    public class Monster
    {
        private int m_size;


        public int Size
        {
            get { return m_size; }
            set
            {
                if (value < 100)
                    value = 100;
                
                m_size = value;
            }
        }
        
        

        public Monster()
        {
            Size = 100;
        }
        
        

        public void Eat()
        {
            Size++;
        }

        public void MakeNoise()
        {
            Console.WriteLine("AAAARRRRGGGHHHH!");
        }
    }
}
