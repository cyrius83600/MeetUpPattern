using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrique_Happy_Hours
{
    public interface IClient
    {
        void AjouterAddition(double prix, int quantite);
        void AfficherAddition();
    }
}
