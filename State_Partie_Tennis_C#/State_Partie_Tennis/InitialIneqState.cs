using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Partie_Tennis
{
    public class InitialIneqState : GameState
    {

        private GameState _nextState;
        private Player playerOne;
        private Player playerTwo;

        public InitialIneqState(Player playerOne, Player playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            Console.WriteLine("Inégalité");
        }


        public override GameState NextState()
        {
            var scoreOne = playerOne.score;
            var scoreTwo = playerTwo.score;
            if (scoreOne > 3 && scoreTwo < 3)
            {
                _nextState = new GamePlayerOne(playerOne, playerTwo);
            }
            else if (scoreTwo > 3 && scoreTwo < 3)
            {
                _nextState = new GamePlayerTwo(playerOne, playerTwo);
            }
            else if (scoreOne == scoreTwo && scoreOne < 3)
            {
                _nextState = new InitialEqState(playerOne, playerTwo);
            }
            else if (scoreOne == scoreTwo && scoreOne == 3)
            {
                _nextState = new DeuceState(playerOne, playerTwo);
            }
            else
            {
                _nextState = new InitialIneqState(playerOne, playerTwo);
            }
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
