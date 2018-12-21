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
            //Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
            //for (int i = 0; i < 256; i++)
            //{
            //    Console.Write(i + "=> [" + (char)i + "]  \n");
            //}
            char c = 'c';
            char b = 'z';
            char a = 'a';
            double convertc = char.GetNumericValue(c);
            double converta = char.GetNumericValue(a);
            double convertb = char.GetNumericValue(b);
            Console.WriteLine("c convert :"+convertc +"a :" + converta + "b : "+convertb);
            char d = '1';
            char e = '2';
            char f = '3';
            char g = '4';
            char h = '5';
            char i = '6';
            char j = '7';
            char k = '8';
            char l = '9';
            char m = '0';

            double convertd = char.GetNumericValue(d);
            double converte = char.GetNumericValue(e);
            double convertf = char.GetNumericValue(f);
            double convertg = char.GetNumericValue(g);
            double converth = char.GetNumericValue(h);
            double converti = char.GetNumericValue(i);
            Console.WriteLine(" convert :" + convertd+converte+convertf+convertg+converth+converti);
            Console.ReadKey();
        }

    }
}
