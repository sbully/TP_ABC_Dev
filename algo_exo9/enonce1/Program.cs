using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            do
            {




                double temp;                                                    // variable tempon pour le switch de valeur

                Console.Clear();
                Console.WriteLine("entrer la valeur de A :");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("entrer la valeur de B:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("entrer la valeur de C:");
                double c = double.Parse(Console.ReadLine());
                if (a < b)                                                      // Le A contiendra le plus grand nombre
                {
                    temp = a;                                                    
                    a = b;                                                      // si A < B on inverse les valeurs pour que A>B
                    b = temp;                                                    

                }
                if (a < c)                                                      // Le A contiendra le plus grand nombre
                {
                    temp = a;
                    a=c;
                    c = temp;                                                   // si A < C on inverse les valeurs pour que A>C

                }
                if (b < c)                                                      // Le C contiendra le plus petit nombre
                {
                    temp = b;
                    b = c;
                    c = temp;                                                   // si B<C on inverse les valeurs pour que B>C
                }

                




                Console.WriteLine("dans l ordre croissant : " + c+" " +b+" "+ a);
                Console.WriteLine("d'autre nombre à échanger? o/n");
                test = Console.ReadLine();









            } while (test == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();
        }
    }
}
