using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Lue käyttäjältä kaksi kokonaislukua sekä operaatio joka lukujen välillä
suoritetaan (voi olla +, -, * tai / eli kyseessä siis nelilaskin).

Käytä operaation tallentamiseen string-tyyppistä muuttujaa.

Tutki switch-case rakenteessa minkä operaation käyttäjä syötti ja
tulosta sen perusteella lukujen laskutoimitus vastauksineen. Osamäärä
tulostetaan kahden desimaalin tarkkuudella

Esimerkiksi
jos käyttäjä syöttää luvut "12" ja "13" ja operaatioksi "+" niin tulostetaan

12 + 13 = 25

Jos operaatio oli annettu väärin, niin tulosta virheilmoitus
"annoit operaation väärin"

Nollalla jakoa ei saa ohjelmassa tapahtua, vaan silloin tulostetaan
"Nollalla jako, ei voida suorittaa"
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.Write("Anna kokonaisluku: ");
            int iLuku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna toinen kokonaisluku: ");
            int iLuku2 = int.Parse(Console.ReadLine());

            Console.Write("Anna operaatio +, -, * , / : ");
            string sOperaatio = Console.ReadLine();

            switch (sOperaatio) 
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", iLuku1, iLuku2, iLuku1 + iLuku2);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", iLuku1, iLuku2, iLuku1 - iLuku2);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", iLuku1, iLuku2, iLuku1 * iLuku2);
                    break;
                case "/":
                    if (iLuku1 == 0 || iLuku2 == 0)
                    {
                        Console.WriteLine("Nollalla jako, ei voida suorittaa");
                    }
                    else
                    {
                        Console.WriteLine("{0} / {1} = {2:F2}", iLuku1, iLuku2, (float)iLuku1 / (float)iLuku2);
                    }                 
                    break;
                default:
                    Console.WriteLine("annoit operaation väärin");
                    break;
            }
        }
    }
}

