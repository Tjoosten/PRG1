using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader lezer = new StreamReader("gegevens5.2.4.2a.txt");

            bool sw = true; // TRUE = links afdrukken. 
            string naam;

            while (! lezer.EndOfStream) // Not end of file.
            {
                naam = lezer.ReadLine();

                if (sw == true)
                {
                    // Links afdrukken. 
                    Console.Write(naam.PadRight(25));
                }
                else
                {
                    // Rechts afdrukken 
                    Console.WriteLine(naam); // Geen padright want dat heeft geen zin. 
                    sw = true; // Volgende keer moet links afdrukken. Vandaar true
                } // ENDIF
            } // End while do. 

            lezer.Close(); // Uw lezer sluiten omdat het nodig is wanneer men werkt met meerdere files. 
            Console.Read(); // Scherm stilhouden. 
        }
    }
}
