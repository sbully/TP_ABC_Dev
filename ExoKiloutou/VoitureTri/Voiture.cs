using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureTri
{

    public class Voiture
    {
        private string numeroDeSerie;
        private string modele;
        private string marque;
        private DateTime miseEnCircu = new DateTime();

        public Voiture(string _numeroDeSerie, string _marque, string _modele)
        {
            numeroDeSerie = _numeroDeSerie;
            modele = _modele;
            marque = _marque;
        }

        public Voiture(string _numeroDeSerie, string _marque, string _modele, DateTime _miseEnCircu)
        {
            numeroDeSerie = _numeroDeSerie;
            modele = _modele;
            marque = _marque;
            miseEnCircu = _miseEnCircu;

        }
        public Voiture(Voiture oldCar, DateTime _miseEnCirculation)
        {
            numeroDeSerie = oldCar.numeroDeSerie;
            modele = oldCar.modele;
            marque = oldCar.marque;
            miseEnCircu = _miseEnCirculation;

        }


        public string SerieVoiture
        {
            get { return numeroDeSerie; }
            set { numeroDeSerie = value; }
        }
        public string ModeleVoiture
        {
            get { return modele; }
            set { modele = value; }
        }
        public string MarqueVoiture
        {
            get { return marque; }
            set { marque = value; }
        }
        public DateTime MiseEnCirculation
        {
            get { return miseEnCircu; }
            set { miseEnCircu = value; }
        }

    }
}
