using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureTri
{
    public class TriModele : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            int compare;
            Voiture maVoiture1 = (Voiture)x;
            Voiture maVoiture2 = (Voiture)y;
            if (maVoiture1.MarqueVoiture.CompareTo(maVoiture2.MarqueVoiture) == -1)
            {
                compare = -1;
            }
            else if (maVoiture1.MarqueVoiture.CompareTo(maVoiture2.MarqueVoiture) == 1)
            {
                compare = 1;
            }
            else
            {
                compare = 0;
            }
            return compare;
        }

        //int IComparer.Compare(object x, object y)
        //{
        //    int compare;
        //    IComparable maVoiture1 = (IComparable)x;
        //    IComparable maVoiture2 = (IComparable)y;
        //    if (maVoiture1.CompareTo(maVoiture2) == -1)
        //    {
        //        compare = -1;
        //    }
        //    else if (maVoiture1.MarqueVoiture.CompareTo(maVoiture2.MarqueVoiture) == 1)
        //    {
        //        compare = 1;
        //    }
        //    else
        //    {
        //        compare = 0;
        //    }
        //    return compare;
        //}
    }
}

