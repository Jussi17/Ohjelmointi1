using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Tee ohjelma, jolla voit laskea kuinka paljon saat työmarkkinatukea kuukaudessa 
jäädessäsi työttömäksi, kun et ole ollut niin pitkään töissä että saisit 
ansiosidonnaista työttömyyspäivärahaa. Työmarkkinatuen ehdot ja määrät ovat 
yksinkertaistettu malli oikeista työmarkkinatuen ehdoista ja ovat seuraavat: 
 
· Työmarkkinatuen määrä on 32,68 euroa/päivä ja sitä maksetaan viideltä päivältä viikossa.
· Lapset korottavat työmarkkinatukea seuraavasti: yksi lapsi 5,27 euroa/pv, kaksi lasta 7,74 euroa/ pv ja kolmesta tai useammasta yhteensä 9,98 e/pv
· Työllistymistä edistävä palvelu korottaa tukea 4,78 e/pv
· Jos tulot ylittävät 300 euroa, niin jokainen sen määrän ylittävä palkkana maksettu euro vähentää tukea 50 senttiä
· Jos asut vanhempiesi taloudessa tukea vähennetään 50% 

Ohjelmalla voi toistaa työmarkkinatuen laskemista niin monta kertaa kuin haluaa. 
Tuki lasketaan kuukaudelle, jossa on 4 viikkoa.

Alla on esimerkki ohjelman toiminnasta:  

Kuinka monta lasta sinulla on: 5
Kuinka monena päivänä olet osallistunut työllistymistä edistävään palveluun: 2
Kuinka paljon olet saanut palkkaa: 320
Asutko vanhempiesi luona (k/e): k
Saat työmarkkinatukea 426.38 euroa kuukaudessa
 
Haluatko laske työmarkkinatuen uusilla tiedoilla (k/e): e

HUOM! Kun käyttäjältä kysytään k/e, niin toteuta sen kysyminen siten, että käyttäjän
pitää painaa enteriä vastauksen jälkeen.
*/
namespace Projekti
{
    class MyProgram
    {
        static void Main()
        {
            int iLapsiMaara, iTyoEdiPalPai;
            float fPalkka, fTukiMaara;
            bool bAsuminen;

            do
            {
                fTukiMaara = 32.68f * 5 * 4;

                Console.Write("Kuinka monta lasta sinulla on: ");
                while (!int.TryParse(Console.ReadLine(), out iLapsiMaara))
                {
                    Console.Write("Virheellinen syöte. Anna lapsien määrä kokonaislukuna: ");
                }

                switch (iLapsiMaara)
                {
                    case 1:
                        fTukiMaara += 5.27f * 5 * 4;
                        break;
                    case 2:
                        fTukiMaara += 7.74f * 5 * 4;
                        break;
                    default:
                        if (iLapsiMaara >= 3)
                        {
                            fTukiMaara += 9.98f * 5 * 4;
                        }
                        break;
                }

                Console.Write("Kuinka monena päivänä olet osallistunut työllistymistä edistävään palveluun: ");
                while (!int.TryParse(Console.ReadLine(), out iTyoEdiPalPai) || iTyoEdiPalPai < 0 || iTyoEdiPalPai > 20)
                {
                    Console.Write("Virheellinen syöte. Anna päivien määrä (0-20): ");
                }
                fTukiMaara += 4.78f * iTyoEdiPalPai;

                Console.Write("Kuinka paljon olet saanut palkkaa: ");
                while (!float.TryParse(Console.ReadLine(), out fPalkka))
                {
                    Console.Write("Virheellinen syöte. Anna palkan määrä lukuna: ");
                }
                if (fPalkka > 300)
                {
                    fTukiMaara -= (fPalkka - 300) * 0.5f;
                }

                Console.Write("Asutko vanhempiesi luona (k/e): ");
                string input = Console.ReadLine().ToLower();
                while (input != "k" && input != "e")
                {
                    Console.Write("Virheellinen syöte. Syötä (k/e): ");
                    input = Console.ReadLine().ToLower();
                }
                bAsuminen = input == "k";
                if (bAsuminen)
                {
                    fTukiMaara *= 0.5f;
                }

                Console.WriteLine("Saat työmarkkinatukea {0:F2} euroa kuukaudessa",fTukiMaara);

                Console.Write("Haluatko laskea työmarkkinatuen uusilla tiedoilla (k/e): ");
                input = Console.ReadLine().ToLower();
                while (input != "k" && input != "e")
                {
                    Console.Write("Virheellinen syöte. Syötä (k/e): ");
                    input = Console.ReadLine().ToLower();
                }
                if (input == "e")
                {
                    break;
                }
                //else if (input == "k")
                //{
                //    Console.Clear();
                //}

            } while (true);
        }
    }
}