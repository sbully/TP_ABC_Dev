using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affichage_table_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
            for (int i = 0; i < 256; i++)
            {
                Console.Write(i + "=> [" + (char)i + "]  \n");
            }
            Console.ReadKey();
        }

    }
}
