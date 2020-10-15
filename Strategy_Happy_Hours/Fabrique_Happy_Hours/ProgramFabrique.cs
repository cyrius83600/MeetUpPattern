using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrique_Happy_Hours
{
    class ProgramFabrique
    {
        static void Main(string[] args)
        {
            var isHappy = true;

            var client = new FabriqueClient().Create(isHappy);
            client.AjouterAddition(5, 1);
            client.AfficherAddition();

            var client2 = new FabriqueClient().Create(!isHappy);
            client2.AjouterAddition(5, 1);
            client2.AfficherAddition();
            
        }
    }
}
