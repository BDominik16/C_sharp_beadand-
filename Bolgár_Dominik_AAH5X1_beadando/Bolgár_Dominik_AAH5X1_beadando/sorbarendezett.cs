using System;
using System.Collections.Generic;
using System.Text;

namespace Bolgár_Dominik_AAH5X1_beadando
{
    class sorbarendezett<T> where T : System.IComparable<T> 
    {
        private SortedDictionary<string, string> neptunfelhasznalok;

        public sorbarendezett(SortedDictionary<string, string> neptunfelhasznalok)
        {
            this.neptunfelhasznalok = neptunfelhasznalok;
        }

        public SortedDictionary<string, string> Neptunfelhasznalok { get => neptunfelhasznalok; set => neptunfelhasznalok = value; }
        


    }
}
