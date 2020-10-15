using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Partie_Tennis
{
    class Program
    {
        static void Main(string[] args)
        {
            var nadal = new Player() { nom = "NADAL", score = 0 };
            var djoko = new Player() { nom = "DJOKO", score = 0};



            GameState etatGame = new InitialEqState(nadal, djoko);
            etatGame.AfficherScore();
            etatGame.PointTo(nadal);
            etatGame = etatGame.NextState();
            etatGame.PointTo(djoko);
            etatGame = etatGame.NextState();
            //etatGame.AfficherScore();
            //etatGame.PointTo(nadal);
            //etatGame = etatGame.NextState();
            //etatGame.AfficherScore();
            //etatGame.PointTo(nadal);
            //etatGame = etatGame.NextState();
            //etatGame.AfficherScore();
            //etatGame.PointTo(nadal);
            //etatGame = etatGame.NextState();
            //etatGame.AfficherScore();
        }
    }
}
