using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoObservable
{
    public class AffichageConditions : IObserver<Mesures>
    {
        private IDisposable unsubscriber;
        private Mesures mesures { get; set; }

        public AffichageConditions()
        {
        }

        public virtual void Subscribe(IObservable<Mesures> observable)
        {
            if (observable != null)
                unsubscriber = observable.Subscribe(this);
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("Completed");
            this.Unsubscribe();
        }

        public virtual void OnError(Exception e)
        {
            Console.WriteLine("Error");
        }

        public void OnNext(Mesures value)
        {
            Console.WriteLine("Dans la station des Affichages Conditions");
            value.AfficherMesures();
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
