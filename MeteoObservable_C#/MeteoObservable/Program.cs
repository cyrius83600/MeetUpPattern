using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoObservable
{
    class Program
    {
        static void Main(string[] args)
        {
            var donneesMeteo = new DonneesMeteo();
            var affichageCond = new AffichageConditions();
            affichageCond.Subscribe(donneesMeteo);
            var mesures = new Mesures(100, 50, 25);
            donneesMeteo.UpdateMesures(mesures);
            mesures.temperature = 200;
            var prevision = new Previsions();
            prevision.Subscribe(donneesMeteo);
            donneesMeteo.UpdateMesures(mesures);
            affichageCond.Unsubscribe();
            mesures.pression = 150;
            donneesMeteo.UpdateMesures(mesures);

        }
    }
}
