using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recherche_Ville_chargement_CSV
{
    [Serializable]
    class Ville
    {
        private string nomVille;
        private string codePostal;

        public string NomVille
        {
            get
            {
                return nomVille;
            }

            set
            {
                nomVille = value;
            }
        }

        public string CodePostal
        {
            get
            {
                return codePostal;
            }

            set
            {
                codePostal = value;
            }
        }

        public Ville(string _codePostal, string _nomVille)
        {
            nomVille = _nomVille;
            codePostal = _codePostal;
        }
        public Ville()
        {
        }
    }
}
