using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
Lue käyttäjältä teksti string tyyppiseen muuttujaan. Muuta koko teksti pieniksi kirjaimiksi 
ja kirjoita tiedostoon "kirjaimet.txt" allekkain joka toinen kirjain alkaen ensimmäisestä.

Esimerkiksi jos alkuperäinen teksti oli "TiiSTaI", niin se muutetaan "tiistai"
ja kirjoitetaan tiedostoon alla olevalla tavalla (HUOM! ei tyhjiä rivejä)

t
i
t
i

HUOM 1!
Path-funktio pitää jättää ohjelmaan ja kun kirjoitat tiedostoon, niin
StreamWriter muuttujan esittely pitää olla näin:

StreamWriter sw = new StreamWriter(Path("kirjaimet.txt"));
*/
namespace Projekti
{
    class MyProgram
    {
        static string Path(string filename)
        {
            return System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "../../../src/", filename);
        }

        public static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(Path("kirjaimet.txt"));
            string teksti;

            Console.WriteLine("Kirjoita tekstiä: ");
            teksti = Console.ReadLine();

            using (sw)
            {
                string sTeksti = teksti.ToLower();
                for (int i = 0; i < sTeksti.Length; i += 2)
                {
                    sw.WriteLine(sTeksti[i]);
                }
            }
            string luettu;

            using (StreamReader sr = new StreamReader(Path("kirjaimet.txt")))
            {
                luettu = sr.ReadToEnd();
            }

            Console.WriteLine(luettu);
        }
    }
}