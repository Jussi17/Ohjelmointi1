using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Lotossa arvotaan seitsemän (7) varsinaista numeroa ja yksi (1) lisänumero. Numerot ovat väliltä 1-40. 
Esittele kahdeksan (8) alkioinen lotto-taulukko ja arvo siihen lottonumerot (7 ensimmäistä on siis 
varsinaisia lottonumeroita ja viimeinen on lisänumero). Muista, että samaa numeroa ei saa tulla 
lottoriviin eli mieti miten voisit tarkistaa onko arvottu numero jo lottorivissä entuudestaan ja 
silloin sen tilalle pitää arpoa uusi numero.

Tulosta ensi arvottu rivi ja sitten lajiteltu lottorivi seuraavasti:

ARVOTTU   : 31 4 1 19 25 16 12 13  
LAJITELTU : 1 4 12 16 19 25 31 + 13

HUOM!! seitsemän varsinaista numeroa on lajiteltu suuruusjärjestykseen! 
Mutta lisänumeroa ei tietenkään saa ottaa lajitteluun mukaan! Löytysköhän Array.Sort:sta 
sellainen ominaisuus, jolla tämän saisi ratkaistua?
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int[] iTaulu = new int[8];
            Random rand = new Random();

            for (int i = 0; i < iTaulu.Length - 1; i++)
            {
                int iLuku;
                do
                {
                    iLuku = rand.Next(1, 41);
                } while (Array.Exists(iTaulu, x => x == iLuku));

                iTaulu[i] = iLuku;
            }

            int iLisa;
            do
            {
                iLisa = rand.Next(1, 41);
            } while (Array.Exists(iTaulu, x => x == iLisa));

            iTaulu[iTaulu.Length - 1] = iLisa;

            Console.Write("ARVOTTU   : ");
            foreach (int numero in iTaulu)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            Array.Sort(iTaulu, 0, iTaulu.Length - 1);

            Console.Write("LAJITELTU : ");
            for (int i = 0; i < iTaulu.Length - 1; i++)
            {
                Console.Write(iTaulu[i] + " ");
            }
            Console.WriteLine("+ " + iTaulu[iTaulu.Length - 1]);
        }
    }
}

