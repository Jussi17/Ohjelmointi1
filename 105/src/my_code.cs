using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele muuttuja pii, jolle annat alkuarvoksi piin likiarvon 6 desimaalin tarkkuudella.
Lue käyttäjältä ympyrän halkaisija ja tulosta ympyrän piiri ja pinta-ala kolmen desimaalin
tarkkuudella seuraavasti (halkaisijaksi annettu 2,5) :

PIIRI     : 7,854
PINTA-ALA : 4,909 
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            float fPii = 3.141593f;
            float fHalkaisija;

            Console.Write("Anna ympyrän halkaisija: ");
            fHalkaisija = float.Parse(Console.ReadLine());

            float fPiiri = fPii * fHalkaisija;
            float fSade = fHalkaisija / 2;
            float fPinta = fPii * fSade * fSade;

            Console.WriteLine("PIIRI     : {0:F3}",fPiiri);
            Console.WriteLine("PINTA-ALA : {0:F3}",fPinta);
        }
    }
}

