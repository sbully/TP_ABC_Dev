using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterfaceFraiche
{
    [Serializable]
    public class ClientMacDo
    {
        private string sexe;
        private string nom;
        private string prenom;
        private string numeroVoie;
        private string rue;
        private int codepostal;
        private string ville;
        private string mail;
        private string dateNaissance;
        private string motdepasse;

        public static List<ClientMacDo> listClient = new List<ClientMacDo>();
        public string Sexe
        {
            get
            {
                return sexe;
            }

            set
            {
                sexe = value;
            }
        }
        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }
        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }
        public string NumeroVoie
        {
            get
            {
                return numeroVoie;
            }

            set
            {
                numeroVoie = value;
            }
        }
        public string Rue
        {
            get
            {
                return rue;
            }

            set
            {
                rue = value;
            }
        }
        public int Codepostal
        {
            get
            {
                return codepostal;
            }

            set
            {
                codepostal = value;
            }
        }
        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
        }
        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }
        public string DateNaissance
        {
            get
            {
                return dateNaissance;
            }

            set
            {
                dateNaissance = value;
            }
        }
        public string Motdepasse
        {
            get
            {
                return motdepasse;
            }

            set
            {
                motdepasse = value;
            }
        }


        public ClientMacDo(string _sexe, string _nom, string _prenom, string _numvoie, string _rue, int _codepostal, string _ville, string _mail, string _naissance, string _motdepasse)
        {
            Sexe = _sexe;
            Nom = _nom;
            Prenom = _prenom;
            NumeroVoie = _numvoie;
            Rue = _rue;
            Codepostal = _codepostal;
            Ville = _ville;
            Mail = _mail;
            DateNaissance = _naissance;
            Motdepasse = _motdepasse;


            listClient.Add(this);
        }
        public ClientMacDo()
        {
        }
    }
}
