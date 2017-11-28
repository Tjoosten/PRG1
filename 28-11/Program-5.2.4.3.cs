using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace oef._5_2._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader lezer = new StreamReader("gegevens5.2.4.2.txt");

            string naam;
            bool sw = true;
            int lijn = 3;

            while (! lezer.EndOfStream)
            {
                naam = lezer.ReadLine();

                if (sw == true)
                {
                    // Links adrukken 
                    // Controlleren of 3 lijnen al zijn afgedrukt. 
                    if (lijn == 3) 
                    {
                        // Neem nieuw blad. Wij doen dat door blanco lijn te nemen. 
                        Console.WriteLine();

                        // Titel drukken. 
                        Console.WriteLine("De namen zijn." . PadLeft(30));

                        // Zet lijn terug op nul. Moet eerst gebeuren voor men de naam drukt. 
                        lijn = 0; 
                    } // ENDIF lijn controle.

                    // Naam afdrukken 
                    Console.Write(naam.PadRight(25));
                    sw = false;
                    lijn++;
                } // ENDIF sw
                else
                {
                    // Naam rechts afdrukken
                    Console.WriteLine(naam);
                    sw = true;
                }
            } // End while do

            lezer.Close();  // Sluit het stream reader object.
            Console.Read(); // Scherm stilhouden
        }
    }
}
