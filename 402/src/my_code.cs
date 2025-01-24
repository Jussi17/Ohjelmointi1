using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Esittele 10 alkioinen int taulukko ja arvo siihen lukuja väliltä 0-10. 
Vain parilliset luvut sallitaan.Jos arvottiin pariton luku niin sen 
tilalle on arvottava uusi luku.

Tulosta luvut ensin taulukon alusta loppuun tabulaattorilla eroteltuna
ja seuraavalla rivillä lopusta alkuun tabulaattorilla eroteltuna
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int[] iTaulu = new int[10];
            Random rand = new Random();         

            for (int i = 0; i < iTaulu.Length;)
            {
                int iLuku = rand.Next(11);

                if (iLuku % 2 == 0)
                {
                    iTaulu[i] = iLuku;
                    Console.Write(iLuku+"\t");
                    i++;
                }
            }
            Console.WriteLine();

            for (int i = iTaulu.Length - 1; i >= 0; i--)
            {
                Console.Write(iTaulu[i] + "\t");
            }
        }
    }
}

