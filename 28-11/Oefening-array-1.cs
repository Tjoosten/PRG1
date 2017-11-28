using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oefening_array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Streamreader moet niet gesloten worden wegens het Using statement. 
            using (StreamReader lezer = new StreamReader("gegevens.txt"))
            {
                // Array declareren voor de muntsoorten 
                string[] munt = new string[] { "Japanse yen.", "amerikaanse yen", "zwitsere frank", "britse pons"};

                // Array declareren voor de koers 
                double[] koers = new Double[4];

                // Lijn lezen 
                string lijn = lezer.ReadLine();

                // Lijn splitten 
                string[] gegeven = lijn.Split(';');

                // De elementen van array gegeven (string) converteren naar double. 
                for (int i = 0; i < gegeven.Length; i++)
                {
                    koers[i] = double.Parse(gegeven[i]);
                }

                // De andere records tot EOF
                while (! lezer.EndOfStream)
                {
                    string regel = lezer.ReadLine();
                    int positie = regel.IndexOf("-");
                    double bedrag = double.Parse(regel.Substring(0, positie));
                    int code = int.Parse(regel.Substring(positie + 1));

                    // Berekening maken. 
                    double euro = bedrag + koers[code - 1];

                    // Berekening afdrukken 
                    Console.WriteLine(bedrag.ToString() + " " + munt[code - 1] + " is " + euro.ToString() + " Euro");
                }
            }

            // Scherm stilhouden
        }
    }
}
