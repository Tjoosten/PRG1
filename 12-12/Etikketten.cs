using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ettiketten
{
    class Program
    {
        static void Main(string[] args) // Hoofdprogramma
        {
            // Declaratie variablen 
            string voornaam, familienaam, invoer;
            int aantal;

            // Kleur console 
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            DrukTekst("Etiketten drukken", ConsoleColor.Red, "Hoofd");
            Console.WriteLine(); // Blanco lijn. 

            // Voornaam opvragen in blauw.
            DrukTekst("Voornaam?", ConsoleColor.Blue, "Klein");
            voornaam = Console.ReadLine();

            // Familienaam opvragen. 
            DrukTekst("Familienaam?", ConsoleColor.Blue, "Klein");
            familienaam = Console.ReadLine();

            DrukTekst("Aantal etiketten?", ConsoleColor.Blue, "Hoofd");
            invoer = Console.ReadLine();

            while (int.TryParse(invoer, out aantal) == true)
            {
                DrukTekst("Aantal etiketten. ", ConsoleColor.Blue, "hoofd");
                invoer = Console.ReadLine();
            }

            // Verwerken van aantal etiketten te drukken. 
            for (int i = 1; i <= aantal; i++)
            {
                if (1%2  == 0)
                {
                    // Even in rood en hoofdletters; 
                    DrukTekst(voornaam + Environment.NewLine + familienaam, ConsoleColor.Red, "hoofd");
                }

                else {
                    // Oneven, in blauw en gwoon zoals ingegeven.
                    DrukTekst(voornaam + Environment.NewLine + familienaam, ConsoleColor.Black, "klein");
                }
                Console.WriteLine();
            }

            // Scherm stilhouden 
            DrukTekst("Druk op een toets...", ConsoleColor.Black, "klein");
            Console.Read();
        } // Eind hoofdprogramma 

        private static void DrukTekst(String tekst, ConsoleColor voorgrond, string grootte)
        {
            // Voorgrond kleur aanpassen  
            Console.ForegroundColor = voorgrond; 

            // Testen hoofd of kleine letters.
            if (grootte.ToUpper() == "HOOFD") {
                tekst.ToUpper();
            }

            Console.WriteLine(tekst);
        }
    }
}
