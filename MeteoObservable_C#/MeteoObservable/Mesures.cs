using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoObservable
{
    public class Mesures
    {
        public float temperature;
        public float hygrometrie;
        public float pression;

        public Mesures()
        {
        }

        public void setMesures(Mesures mesures)
        {
            this.temperature = mesures.temperature;
            this.hygrometrie = mesures.hygrometrie;
            this.pression = mesures.pression;
        }

        public void AfficherMesures()
        {
            Console.WriteLine("Temperature : " + temperature);
            Console.WriteLine("Humidite : " + hygrometrie);
            Console.WriteLine("Pression : " + pression);
        }

        public Mesures(float temperature, float hygrometrie, float pression)
        {
            this.temperature = temperature;
            this.hygrometrie = hygrometrie;
            this.pression = pression;
        }
    }
}
