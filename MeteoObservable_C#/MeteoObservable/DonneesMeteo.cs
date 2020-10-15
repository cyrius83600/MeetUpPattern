using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoObservable
{
    public class DonneesMeteo : IObservable<Mesures>
    {
        private List<IObserver<Mesures>> observers;

        public DonneesMeteo()
        {
            observers = new List<IObserver<Mesures>>();
        }

        public void UpdateMesures(Mesures mes)
        {
            foreach (var observer in observers)
            {
                    observer.OnNext(mes);
            }
        }

        public IDisposable Subscribe(IObserver<Mesures> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }


        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Mesures>> _observers;
            private IObserver<Mesures> _observer;

            public Unsubscriber(List<IObserver<Mesures>> observers, IObserver<Mesures> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
