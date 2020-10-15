using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Partie_Tennis
{
    public class AdvantagePlayerOne : GameState
    {

        private GameState _nextState;
        private Player playerOne;
        private Player playerTwo;

        public AdvantagePlayerOne(Player playerOne, Player playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            Console.WriteLine("Advantage " + playerOne.nom);
        }


        public override GameState NextState()
        {
            var scoreOne = playerOne.score;
            var scoreTwo = playerTwo.score;
            if(scoreOne == scoreTwo)
            {
                _nextState = (GameState)new DeuceState(playerOne, playerTwo);
            }
            else
            {
                _nextState = new GamePlayerOne(playerOne, playerTwo);
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
