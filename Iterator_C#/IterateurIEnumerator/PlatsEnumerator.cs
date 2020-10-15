//using IterateurBasique;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateurIEnumerator
{
    public class PlatsEnumerator : IEnumerator
    {
        public Plat[] _plats;
        int position = -1;

        public PlatsEnumerator(Plat[] tab)
        {
            _plats = tab;
        }

        public object Current
        {
            get
            {
                return _plats[position];
            }
        }

        public bool MoveNext()
        {
            position++;
            return position < this._plats.Length;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Afficher()
        {
            Console.WriteLine("Ca marche");
        }
    }
}
