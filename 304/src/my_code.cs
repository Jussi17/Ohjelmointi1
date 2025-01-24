using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Kysy käyttäjältä mistä luvusta tulostetaan ja mihin asti ja millaisella askelluksella. 

HUOM! Mistä on oltava pienempi kuin mihin ja askelluksen oltava suurempi kuin 0.
Muuten kysyttävä tiedot uudestaan.

Tulosta lukusarjat sekä while-, do-while- että for-silmukoilla. 

Esimerkki:
Jos mistä on 5, mihin on 11 ja askellus on 2, niin ohjelma tulostaa kaikilla
kolmella silmukalla saman, alla olevan lukusarjan (lukujen välissä kaksi välilyöntiä).
Tulosta myös millä silmukalla luvut on tulostettu. 

WHILE:
5  7  9  11

DO-WHILE:
5  7  9  11

FOR:
5  7  9  11
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int iAlku, iLoppu, iAskel;

            while (true)
            {
                Console.Write("Mistä luvusta alkaa: ");
                iAlku = int.Parse(Console.ReadLine());

                Console.Write("Mihin lukuun päättyy: ");
                iLoppu = int.Parse(Console.ReadLine());

                Console.Write("Askelus: ");
                iAskel = int.Parse(Console.ReadLine());

                if (iAlku < iLoppu && iAskel > 0)
                {
                    break;
                }
                Console.WriteLine("Alkava luku pitää olla pienempi kuin päättyvä ja askellus suurempi kuin 0");
            }
 

            Console.WriteLine();

            Console.WriteLine("WHILE:");
            int i = iAlku;
            while (i <= iLoppu)
            {
                Console.Write("{0}  ",i);
                i += iAskel;
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("DO-WHILE:");
            i = iAlku;
            do
            {
                Console.Write("{0}  ", i);
                i += iAskel;
            } while (i <= iLoppu);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("FOR:");
            for (i = iAlku; i <= iLoppu; i += iAskel)
            {
                Console.Write("{0}  ", i);
            }
            Console.WriteLine();
        }
    }
}

