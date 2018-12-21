using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

namespace Compte
{
    class Compte : IDisposable
    {
        private int numero;
        private string nom;
        bool disposed;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
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

        public Compte(string _nom, int _numero)
        {
            nom = _nom;
            numero = _numero;
        }
        public void Affichage()
        {
            Console.WriteLine("nom du proprio : " + nom + " numero du compte :" + numero);

        }

        public void Dispose()
        {
            Console.WriteLine("Destruction du compte de :" + this.nom);
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
                handle.Dispose();
            }
            disposed = true;

        }
        ~Compte()
        {
            Dispose(false);
        }

    }


}
