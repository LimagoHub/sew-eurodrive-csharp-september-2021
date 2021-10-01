using System;

namespace de.sew.csharpkurs
{
    public class Stapel
    {

        private int[] data;
        private int index;
        
        public Stapel()
        {
            data = new int[10];
            index = 0;
        }


        public bool IsEmpty
        {
            get
            {
              return index <= 0;
            }
        }

        public bool IsFull
        {
            get
            {
                return index >= data.Length;
            }
        }


        public void Push(int value)
        {
            if (IsFull) return;
            
            data[index++] = value;
        }

        public int Pop()
        {
            if (IsEmpty)
                return 0;
            
            return data[--index];
        }
        
        
        
    }
}
