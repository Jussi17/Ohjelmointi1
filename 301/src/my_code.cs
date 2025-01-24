using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä kokonaislukuja while-silmukassa, kunnes käyttäjä syöttää arvon -1. 
Sen jälkeen tulosta syötettyjen lukujen keskiarvo yhden desimaalin tarkkuudella
alla olevalla tavalla:

"Keskiarvo : 12.1"

Lukua -1 ei oteta keskiarvon laskentaan mukaan.

Jos käyttäjä ei syöttänyt yhtään lukua, niin keskiarvoa ei saa tulostaa
vaan silloin tulostetaan

"Et antanut yhtään lukua"
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int iLuku, iSumma = 0, iMaara = 0;

            Console.WriteLine("Syötä kokonaislukuja: ");

            while (true)
            {
                iLuku = int.Parse(Console.ReadLine());

                if (iLuku == -1)
                {
                    break;
                }

                iSumma += iLuku;
                iMaara++;
            }

            if (iMaara > 0)
            {
                double dKeskiarvo = (double)iSumma / iMaara;
                Console.WriteLine("Keskiarvo : {0:F1}", dKeskiarvo);
            }
            else
            {
                Console.WriteLine("Et antanut yhtään lukua");
            }
        }
    }
}
