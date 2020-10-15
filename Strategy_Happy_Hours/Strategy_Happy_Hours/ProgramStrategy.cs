using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Happy_Hours
{
    class ProgramStrategy
    {
        static void Main(string[] args)
        {
            var prixNormal = new NormalStrategy();
            var prixReduit = new HappyHoursStrategy();

            var client1 = new Client(prixReduit);
            client1.AjouterAddition(4.5, 1);
            client1.AfficherAddition();
            client1.AjouterAddition(7, 1);
            client1.AfficherAddition();

            client1.Strategy = prixNormal;
            client1.AjouterAddition(4.5, 1);
            client1.AfficherAddition();
            client1.AjouterAddition(7, 1);
            client1.AfficherAddition();

        }
    }
}
