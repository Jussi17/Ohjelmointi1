using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä ympyrän säde liukulukuna.

Kysy käyttäjältä myös, haluaako hän tehdä kumpaa seuraavista
(eli käyttäjä syöttää joko numeron 1 tai 2) :

    1 = laske ympyrän piiri
    2 = laske ympyrän pinta-ala

Tämän vastauksen perusteella laske dTulos-muuttujaan joko piiri
tai pinta-ala ja tulosta se. 

Toteuta tämä sekä if-rakenteella että ehdollisella operaattorilla.
Tulostus pitää siis tehdä kaksi kertaa alla olevalla tavalla:

Tulos : 12.22
Tulos : 12.22
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.Write("Syötä ympyrän säde: ");
            double dSade = double.Parse(Console.ReadLine());

            Console.WriteLine("Kumman haluat laskea?: ");
            Console.WriteLine("1 = laske ympyrän piiri");
            Console.WriteLine("2 = laske ympyrän pinta-ala");
            int iValinta = int.Parse(Console.ReadLine());

            double dTulos;

            if (iValinta == 1)
            {
                dTulos = 2 * Math.PI * dSade;
                Console.WriteLine("Tulos : " + dTulos.ToString("F2"));
            }
            else if (iValinta == 2)
            {
                dTulos = Math.PI * dSade * dSade;
                Console.WriteLine("Tulos : " + dTulos.ToString("F2"));
            }

            dTulos = (iValinta == 1) ? (2 * Math.PI * dSade) : (Math.PI * dSade * dSade);
            Console.WriteLine("Tulos : " + dTulos.ToString("F2"));
        }
    }
}

