using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrique_Happy_Hours
{
    public class FabriqueClient
    {
        public IClient Create(bool isHappyHours)
        {
            IClient client = new ClientNormal();

            if(isHappyHours)
            {
                client = new ClientHappy();
            }

            return client;
        }
    }
}
