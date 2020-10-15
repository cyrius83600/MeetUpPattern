using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Partie_Tennis
{
    public class AdvantagePlayerTwo : GameState
    {
        private GameState _nextState;
        private Player playerOne;
        private Player playerTwo;

        public AdvantagePlayerTwo(Player playerOne, Player playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            Console.WriteLine("Advantage " + playerTwo.nom);
        }



        public override GameState NextState()
        {
            var scoreOne = playerOne.score;
            var scoreTwo = playerTwo.score;
            if(scoreOne == scoreTwo)
            {
                _nextState = new DeuceState(playerOne, playerTwo);
            }
            else
            {
                _nextState = new GamePlayerTwo(playerOne, playerTwo);
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
