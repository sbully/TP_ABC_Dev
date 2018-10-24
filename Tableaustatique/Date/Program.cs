using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime naissance = new DateTime();
            DateTime datenow = DateTime.Today;
            int compare;
            int age;


            bool testparse;
            //TimeSpan interval;

            do
            {
                Console.WriteLine("entrez votre date de naissance (jj/mm/aaaa)");
                testparse = DateTime.TryParse(Console.ReadLine(), out naissance);

            } while (!testparse);

            // avec timespan
            //interval = datenow.Subtract(naissance);

            //age = interval.Days / 365;

            //Console.WriteLine("vous avez : {0} ans", age);

            // avec compareto

            compare = (naissance.AddYears(18)).CompareTo(datenow);
            if (compare == -1)
            {
                Console.WriteLine("si tu es né le "+naissance.ToString("D")+" alors tu es majeur");
            }
            if (compare == 0)
            {
                Console.WriteLine(" C'est ton anniversaire aujourd'hui! Bon anniversaire");
            }
            if (compare == 1)
            {
                Console.WriteLine("si tu es né le : "+naissance.ToString("D")+" tu es mineur");
            }


            Console.ReadKey();

        }
    }
}
