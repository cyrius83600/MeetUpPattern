using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterCRA
{
    public class Client
    {
        public void AfficherCRA(IDeveloppeur developpeur)
        {
            Console.WriteLine(developpeur.RentrerCRA());
        }
    }
}
