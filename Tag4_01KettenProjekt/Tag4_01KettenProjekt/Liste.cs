using System;

namespace de.sew.collections
{
    public class Liste
    {

        private Kettenglied start;
        private Kettenglied akt;
        
        
        public Liste()
        {
            start = akt = null;
        }


        public void Append(Object value) // 1000
        {
            Kettenglied neu = new Kettenglied(value);
            if (IsEmpty)
            {
                start = neu;
            }
            else
            {
                MoveLast();
                akt.nach = neu; // Zeiger hinten
                neu.vor = akt; // Zeiger nach vorne
               
            }
            akt = neu;
        }

        
        
        // Nicht programmieren
        public bool Remove()
        {
           
            
            
            return false;
        }

        public bool Update(Object newValue)
        {
            if(IsEmpty) return false;
            akt.data = newValue;
            return true;
        }

        public Object Get()
        {
            if (IsEmpty)  return null;

            return akt.data;
        }


        public bool MovePrevious()
        {
            if(IsBeginOfList) return false;

            akt = akt.vor;

            return true;
        }

        public bool MoveNext()
        {
            if (IsEndOfList) return false;

            akt = akt.nach;

            return true;
        }

        public bool MoveFirst()
        {
            if (IsEmpty) return false;
            akt = start;
            return true;
        }

        public bool MoveLast()
        {
            if(IsEmpty) return false;
            while (MoveNext())
            {
                // Ok
            }

            return true;
        }

        public bool IsEmpty
        {
            get { return start == null; }
        }
        // ist true wenn entweder die Liste leer ist oder der Cursor AUF dem letzten Element steht
        public bool IsEndOfList
        {
            get { return IsEmpty || akt.nach == null; }
        }
        // ist true wenn entweder die Liste leer ist oder der Cursor AUF dem ersten Element steht
        public bool IsBeginOfList
        {
            get { return start == akt; }
            // get { return IsEmpty || akt.vor == null; }
        }

        class Kettenglied
        {
            public Kettenglied vor;
            public Kettenglied nach;
            public Object data; // 1000

            public Kettenglied(Object newdata)
            {
                data = newdata;
                vor = nach = null;
            }
        }
    }
}
