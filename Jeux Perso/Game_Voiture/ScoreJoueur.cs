using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Voiture
{
    [Serializable]
    public class ScoreJoueur
    {

        private string nomJoueur;
        private int voitureEvite;
        private int distance;

        public ScoreJoueur(string Joueur, int _voitEvit, int _distance)
        {
            nomJoueur = Joueur;
            voitureEvite = _voitEvit;
            distance = _distance;
        }
        public string NomJoueur
        {
            get { return nomJoueur; }
            set { nomJoueur = value; }
        }
        public int VoitureEvite
        {
            get { return voitureEvite; }
            set { voitureEvite = value; }
        }
        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }
    }
}
