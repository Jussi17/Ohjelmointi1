using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Lue käyttäjältä pitkähkö teksti string muuttujaan. Muuta kaikki kirjaimet isoiksi kirjaimiksi 
ja tulosta muutettu teksti. Korvaa kaikki isot A kirjaimet huutomerkillä ja tulosta teksti. 
Poista kaikki välilyönnit ja tulosta teksti. Tulosta lopuksi kaikki merkit lopusta alkuun 
yhdellä välilyönnillä eroteltuna 
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            string sTeksti;

            Console.Write("Anna tekstiä: ");
            sTeksti = Console.ReadLine();

            sTeksti = sTeksti.ToUpper();
            Console.WriteLine(sTeksti);

            sTeksti = sTeksti.Replace('A', '!');
            Console.WriteLine(sTeksti);

            sTeksti = sTeksti.Replace(" ", "");
            Console.WriteLine(sTeksti);

            char[] cKaannetty = sTeksti.ToCharArray();
            Array.Reverse(cKaannetty);
            Console.WriteLine(string.Join(" ", cKaannetty));
        }
    }
}
