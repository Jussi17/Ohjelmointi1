using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele ja anna alkuarvot muuttujille, joihin pitäisi tallentaa seuraavat tiedot:

piin likiarvo
lähiosoite
henkilötunnus
nimesi ensimmäinen kirjain
lämpötila yhden desimaalin tarkkuudella

Tulosta arvot muuttujista allekkain käyttäen sekä Console.WriteLine(), että Console.Write()-komentoja.
Ohjelman pitää tulostaa seuraavat tiedot:

3.14159
Munkkikuja 3
121299A1234
S
-12.4
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            //Esitellään muuttujat
            float fPii = 3.14159f;
            float fLampo = -12.4f;
            string sOsoite = "Munkkikuja 3";
            string sHetu = "121299A1234";
            char cEka = 'S';

            //Tulostetaan allekkain eri tavoilla
            Console.WriteLine(fPii);
            Console.Write(sOsoite + "\n");
            Console.WriteLine("{0}", sHetu);
            Console.Write("{0}" + "\n" + "{1}", cEka, fLampo);
        }
    }
}
