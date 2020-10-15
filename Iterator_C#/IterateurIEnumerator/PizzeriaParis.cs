using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateurIEnumerator
{
    public class MenuPizzeriaParis : IEnumerable
    {
        static int nbMaxiPlats = 6;
        int nbPlats = 0;
        Plat[] plats;

        public MenuPizzeriaParis()
        {
            plats = new Plat[nbMaxiPlats];

            ajouterPlat("Tartiflette", 14.00);
            ajouterPlat("Chorizo", 11.00);
            ajouterPlat("QuatreSaisons", 10.00);
            ajouterPlat("QuatreFromages", 10.50);
            ajouterPlat("Raclette", 12.50);
            ajouterPlat("Merguez", 13.50);
        }

        public void ajouterPlat(string nom, double prix)
        {
            if(nbPlats < nbMaxiPlats)
            {
                plats[nbPlats] = new Plat(nom, prix);
                nbPlats++;
            }
        }

        public PlatsEnumerator GetEnumerator()
        {
            return new PlatsEnumerator(plats);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public Plat[] getPlats()
        {
            return plats;
        }
    }
}
