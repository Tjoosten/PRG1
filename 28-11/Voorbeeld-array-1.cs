using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace array_voorbeeld_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader lezer = new StreamReader("gegevens5.2.4.2.txt");

            // Array declareren met 10 elementen van het trype string. 
            // [] Verwijzinging dat de typehint een array is. 
            string[] namen = new string[10];

            // Aanvullen van array
            // for (int i = 0; i < 10; i++)
            for (int i = 0; i < namen.Length; i++)
            {
                namen[i] = lezer.ReadLine();
            }

            // Array afdrukken op console. 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(namen[i]);
            }

            // Ook mogelijk met het volgende
            // foreach (string element in namen)
            // {
            //     Console.WriteLine(element);
            // }

            // Hou het scherm stil. 
            Console.Read();
        }
    }
}
