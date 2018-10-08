using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcolor
{
    class Program
    {
        static void Main()
        {
            //
            // Write one green line.
            //
            WriteFullLine("This line is green.");
            Console.WriteLine();
            //
            // Write another green line.
            //
            WriteFullLine("This line is also green.");
            Console.WriteLine("pas celle la");
            Console.ReadKey();
        }

        static void WriteFullLine(string value)
        {
            //
            // This method writes an entire line to the console with the string.
            //
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 1)); // <-- see note
                                                                        //
                                                                        // Reset the color.
                                                                        //
            Console.ResetColor();
            
        }
    }
}
