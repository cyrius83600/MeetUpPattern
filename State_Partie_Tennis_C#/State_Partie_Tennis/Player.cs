using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Partie_Tennis
{
    public class Player
    {
        public int score;
        public string nom;

        public void Afficher()
        {
            Console.WriteLine("Score de " + nom + " : " + ConvertToText(score));
        }

        public void AugmenterScore()
        {
            score++;
        }

        private string ConvertToText(int score)
        {
            switch (score)
            {
                case 0:
                    return "0";
                case 1:
                    return "15";
                case 2:
                    return "30";
                case 3:
                    return "40";
                case 4:
                    return "40+";
            }
            return "";
        }
    }

}