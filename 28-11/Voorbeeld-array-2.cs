using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace voorbeeld_array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader lezer = new StreamReader("gegevens.text");

            string lijn = lezer.ReadLine(); // Lijn lezen uit bestand. 

            double[] getallen = new double[5];
            string[] gegeven  = lijn.Split(","); // Om nog een vreemde manier smijt hij hier een record.

            // De elementen van array (string) gegeven omzetten naar elementen van getallen. (double)
            for (int i = 0; i < gegeven.Length; i++)
            {
                getallen[i] = double.Parse(gegeven[i]);
            }

            // De getallen afdrukken. 
            for (int i = 0; i < getallen.Length; i++)
            {
                Console.WriteLine(getallen[i].ToString());
            }

            lezer.Close(); // Lezer sluiten
            Console.ReadLine(); // Scherm stilhouden. 
        }
    }
}
