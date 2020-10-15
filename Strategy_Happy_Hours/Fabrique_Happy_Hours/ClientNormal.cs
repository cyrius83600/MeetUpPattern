using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrique_Happy_Hours
{
    public class ClientNormal : IClient
    {
        public double taux { get; set; }
        public List<double> Addition = new List<double>();

        public ClientNormal()
        {
            taux = 1;
        }

        public void AjouterAddition(double prix, int quantite)
        {
            Addition.Add(taux * prix * quantite);
            Console.WriteLine(quantite + "boissons au prix total de "
                                       + taux * prix * quantite
                                  + " et au prix original de " + prix * quantite);
        }

        public void AfficherAddition()
        {
            Console.WriteLine($"Montant du : {Addition.Sum()}");
        }
    }
}
