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
            DateTime datenow = DateTime.Now;
            int age;
            

            bool testparse;
            TimeSpan interval;

            do
            {
                Console.WriteLine("entrez votre date de naissance (jj/mm/aaaa)");
                testparse = DateTime.TryParse(Console.ReadLine(), out naissance);

            } while (!testparse);

            interval = datenow.Subtract(naissance);

            age = interval.Days / 365;

            Console.WriteLine("vous avez : {0} ans", age);
            Console.ReadKey();

        }
    }
}
