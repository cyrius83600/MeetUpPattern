using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Partie_Tennis
{
    public class DeuceState : GameState
    {
        private GameState _nextState;
        private Player playerOne;
        private Player playerTwo;

        public DeuceState(Player playerOne, Player playerTwo)
        {
            playerOne.score = 3;
            playerTwo.score = 3;
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }

        public override GameState NextState()
        {
            var scoreOne = playerOne.score;
            var scoreTwo = playerTwo.score;
            if(scoreOne < scoreTwo)
            {
                _nextState = new AdvantagePlayerTwo(playerOne, playerTwo);
            }
            else
            {
                _nextState = new AdvantagePlayerOne(playerOne, playerTwo);
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
