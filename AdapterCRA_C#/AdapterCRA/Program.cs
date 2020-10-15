using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterCRA
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            var developpeur = new DeveloppeurExtia();
            client.AfficherCRA(developpeur);

            var architecte = new Architecte();
            var adapte = new Adapteur(architecte);
            client.AfficherCRA(adapte);
        }
    }
}
