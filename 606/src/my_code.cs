using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Tehtävänä on laskea pankkisiirtojen viitteistä tuttu tarkistenumero ja
tulostaa viitenumero ryhmiteltynä.

Alla on esimerkki laskemisesta. Lasketaan runko-osalle 12345 tarkistenumero:

          runko-osa     1     2     3     4     5
     painokertoimet     3     7     1     3     7
                        -------------------------
              tulot     3    14     3    12    35

näiden tulojen summa on 67

Siis oikealta alkaen kerrotaan numerot vuorollaan painoilla 
7, 3, 1, 7, 3, 1, 7, ... jne

Tarkistenumero on tulojen summa vähennettynä seuraavasta täydestä 
kymmenestä (paitsi jos summa on tasakymmeniä, on tarkiste nolla). 

Esimerkin tapauksessa siis tarkiste on 3. 

Alkuperäinen runko-osa ja tarkiste tulostetaan ruudulle näin: oikeanpuoleisimpaan 
ryhmään neljä + tarkiste, muihin viisi merkkiä ja ekaan niin monta kuin riittää

Ohjelman tulisi toimia seuraavasti:

Anna viitteen runko-osa : 325308000102798049011

Viitenumero : 32 53080 00102 79804 90117
*/
namespace Projekti
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Anna viitteen runko-osa: ");
            string runkoOsa = Console.ReadLine();

            int tarkisteNumero = LaskeTarkistusNumero(runkoOsa);
            string viiteNumero = runkoOsa + tarkisteNumero;

            string formViiteNumero = ViiteNumeroFormaatti(viiteNumero);
            Console.WriteLine("Viitenumero : " + formViiteNumero);
        }

        public static int LaskeTarkistusNumero(string runkoOsa)
        {
            int[] painotus = { 7, 3, 1 };
            int summa = 0;
            int pituus = runkoOsa.Length;

            for (int i = 0; i < pituus; i++)
            {
                int luku = int.Parse(runkoOsa[pituus - 1 - i].ToString());
                summa += luku * painotus[i % 3];
            }

            int seuraavaKymmen = (int)Math.Ceiling(summa / 10.0) * 10;
            int tarkistusNro = seuraavaKymmen - summa;

            return tarkistusNro;
        }

        public static string ViiteNumeroFormaatti(string viiteNumero)
        {
            StringBuilder formatoitu = new StringBuilder();
            int pituus = viiteNumero.Length;

            for (int i = 0; i < pituus; i++)
            {
                if (i > 0 && (pituus - i) % 5 == 0)
                {
                    formatoitu.Append(" ");
                }
                formatoitu.Append(viiteNumero[i]);
            }

            return formatoitu.ToString();
        }
    }
}