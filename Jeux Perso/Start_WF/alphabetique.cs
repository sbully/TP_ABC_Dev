using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Start_WF
{
    public class Alphabetique /*: IComparer*/
    {
        public int Compare(Object x, Object y)
        {
            int compare = 0;
            JoueurScore J1 = (JoueurScore)x;
            JoueurScore J2 = (JoueurScore)y;
            if (J1.Joueur.CompareTo(J2.Joueur) == 1)
            {
                compare = 1;
            }
            else if (J1.Joueur.CompareTo(J2.Joueur) == 0)
            {
                compare = 0;
            }
            else
            {
                compare = -1;
            }
            return compare;
        }
    }
}
