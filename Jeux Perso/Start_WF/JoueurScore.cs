using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start_WF
{
    [Serializable]
    public class JoueurScore : IComparable   // classe JoueurScore
    {

        public int CompareTo(Object other)
        {

            int compare = 0;
            JoueurScore v1 = (JoueurScore)other;
            if (this.ScoreJoueur > v1.ScoreJoueur)
            {
                compare = +1;
            }
            if (this.ScoreJoueur == v1.ScoreJoueur)
            {
                compare = 0;
            }
            else
            {
                compare = -1;
            }

            return compare;
        }

        private string NomJoueur;
        private int ScoreJoueur;
        private string DiffLvl;

        public JoueurScore(string Joueur, int Score, string Niveau)
        {
            NomJoueur = Joueur;
            ScoreJoueur = Score;
            DiffLvl = Niveau;
        }
        public string Joueur
        {
            get { return NomJoueur; }
            set { NomJoueur = value; }
        }
        public int Score
        {
            get { return ScoreJoueur; }
            set { ScoreJoueur = value; }
        }
        public string Niveau
        {
            get { return DiffLvl; }
            set { DiffLvl = value; }
        }
        //public static object ConverteToObject(JoueurScore J)
        //{
        //    object retour = new object();
        //    return retour (((string)J.NomJoueur), ((int)J.ScoreJoueur),((string)J.DiffLvl) );
        //}

    }
}
