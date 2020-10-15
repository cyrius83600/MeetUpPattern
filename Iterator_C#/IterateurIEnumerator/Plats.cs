using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateurIEnumerator
{
    public class Plat
    {
        public string nom { get; set; }
        public double prix { get; set; }

        public Plat(){}

        public Plat(string nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;
        }

        
    }
}
