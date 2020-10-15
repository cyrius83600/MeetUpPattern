using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Partie_Tennis
{
    public abstract class GameState
    {
        public abstract void PointTo(Player player);
        public abstract GameState NextState();
        public abstract void AfficherScore();



    }
}
