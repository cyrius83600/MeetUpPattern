using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Partie_Tennis
{
    public class InitialEqState : GameState
    {
        private GameState _nextState;
        private Player playerOne;
        private Player playerTwo;

        public InitialEqState(Player playerOne, Player playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            Console.WriteLine("Egalité");
        }

        public override GameState NextState()
        {
            _nextState = new InitialIneqState(playerOne, playerTwo);
            return _nextState;
        }

        public override void PointTo(Player player)
        {
            player.AugmenterScore();
        }

        public override void AfficherScore()
        {
            playerOne.Afficher();
            playerTwo.Afficher();
        }

    }
}
