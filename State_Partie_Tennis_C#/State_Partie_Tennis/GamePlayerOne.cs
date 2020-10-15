using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Partie_Tennis
{
    public class GamePlayerOne : GameState
    {

        private Player playerOne;
        private Player playerTwo;

        public GamePlayerOne(Player playerOne, Player playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            Console.WriteLine("Victoire : " + playerOne.nom);
        }

        public override GameState NextState()
        {
            return this;
        }

        public override void PointTo(Player player){}

        public override void AfficherScore()
        {
            playerOne.Afficher();
            playerTwo.Afficher();
        }
    }
}
