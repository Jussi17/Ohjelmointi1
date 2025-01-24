using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä merkkejä, kunnes käyttäjä painaa enteriä. Isot kirjaimet tulostuvat pienenä 
ja pienet kirjaimet tulostuvat isona. Muut merkit eivät tulostu.

Riittää, että toimii kirjaimilla väliltä a-z ja A-Z.
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            ConsoleKeyInfo syote;
            char cMerkki;

            Console.Write("Paina jotain näppäintä: ");

            while (true)
            {
                syote = Console.ReadKey(intercept: true);
                cMerkki = syote.KeyChar;

                if (syote.Key == ConsoleKey.Enter)
                {
                    break;
                }

                if (char.IsLower(cMerkki))
                {
                    Console.WriteLine(char.ToUpper(cMerkki));
                }

                else if (char.IsUpper(cMerkki))
                {
                    Console.WriteLine(char.ToLower(cMerkki));
                }
            }
        }
    }
}

