using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele sellainen 2-ulottoinen taulukko, johon voit tallentaa maanantain ja perjantain välisenä aikana 
neljä mittaustulosta jokaiselta päivältä (mittaustulos on sademäärä milleinä). Lue käyttäjältä nämä 
mittaustulokset taulukkoon ja tulosta lopuksi jokaisen päivän mittaustulosten 
keskiarvo seuraavan esimerkin mukaisesti :

Maanantai   : 12.0 mm
Tiistai     : 0.0 mm
Keskiviikko : 1.9 mm
Torstai     : 22.8 mm
Perjantai   : 0.9 mm
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double[,] dTaulu = new double[5,4];
            string[] sPaivat = { "Maanantai", "Tiistai", "Keskiviikko", "Torstai", "Perjantai" };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Syötä sademäärät (mm) {0}-päivän aikana:", sPaivat[i]);

                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Mittaustulos {0}: ",j+1);
                    dTaulu[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < dTaulu.GetLength(0); i++)
            {
                double summa = 0;
                for (int j = 0; j < dTaulu.GetLength(1); j++)
                {
                    summa += dTaulu[i, j];
                }
                double dKeski = summa / 4;
                Console.WriteLine("{0, -11} : {1:F1} mm", sPaivat[i],dKeski);
            }
        }
    }
}

