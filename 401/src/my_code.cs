using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele 3 alkioinen double taulukko ja lue siihen käyttäjältä arvot. 
Tulosta lopuksi syötettyjen lukujen summa ja keskiarvo seuraavasti:

SUMMA :     12.23
KESKIARVO : 4.07
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double[] dTaulu = new double[3];

            for (int i = 0; i < dTaulu.Length; i++)
            {
                Console.Write("Syötä arvo alkioon {0}: ", i + 1);
                dTaulu[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("SUMMA :     {0:f2}", dTaulu.Sum());
            Console.WriteLine("KESKIARVO : {0:f2}", dTaulu.Average());
        }       
    }
}
