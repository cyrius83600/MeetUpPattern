
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateurIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuParis = new MenuPizzeriaParis();
            foreach(Plat plat in menuParis)
            {
                Console.WriteLine(plat.nom + " : " + plat.prix);
            }
            
        }
    }
}
