using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterfaceFraiche
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
            NomVille = _nomVille;
            CodePostal = _codePostal;
        }

        public Ville()
        {
        }
    }
}
