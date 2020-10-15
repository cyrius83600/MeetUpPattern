using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterCRA
{
    public class Adapteur : IDeveloppeur
    {
        Architecte adapte { get; set; }

        public Adapteur(Architecte adapte)
        {
            this.adapte = adapte;
        }

        public string RentrerCRA()
        {
            return adapte.SaisirCRA();
        }
    }
}
