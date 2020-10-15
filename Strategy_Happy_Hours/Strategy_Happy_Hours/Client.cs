using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Happy_Hours
{
    public class Client
    {
        public List<double> Addition = new List<double>();
        public IBillingStrategy Strategy { get; set; }

        public Client()
        {

        }
        public Client(IBillingStrategy strategy)
        {
            Strategy = strategy;
        }

        public void AjouterAddition(double prix, int quantite)
        {
            Addition.Add(Strategy.GetPrice(prix * quantite));
            Console.WriteLine(quantite + "boissons au prix total de " 
                                       + Strategy.GetPrice(prix * quantite)
                                  + " et au prix original de " + prix * quantite);
        }

        public void AfficherAddition()
        {
            Console.WriteLine($"Montant du : {Addition.Sum()}");
        }
    }
}
