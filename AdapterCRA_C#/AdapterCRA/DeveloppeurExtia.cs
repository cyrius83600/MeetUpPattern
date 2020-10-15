using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterCRA
{
    public class DeveloppeurExtia : IDeveloppeur
    {
        public string RentrerCRA()
        {
            return "J'ai saisi mon CRA de développeur";
        }
    }
}
