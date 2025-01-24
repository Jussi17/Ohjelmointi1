using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
Arvo 40 kpl liukulukuja väliltä 1.4 – 5.8 ja kirjoita ne "datat.txt" tiedostoon allekkain. 
Älä käytä taulukkoa tässä vaiheessa.

Sen jälkeen luo 40 alkioinen double-taulukko ja lue 
arvot tiedostosta taulukkoon. Tämän jälkeen tulosta taulukon lukujen 
summa, keskiarvo, minimiarvo ja maksimiarvo seuraavalla tavalla

SUMMA : 143.2
KA    : 3.6
MIN   : 1.4
MAX   : 5.7

Käytä funktioita:

ArvoJaTallennaTiedostoon
LueTiedostosta
TulostaTiedot


HUOM 1!
Kaikkien funktioiden otsikkorivien eteen on laitettava public. Esimerkiksi
public static void Main()

HUOM 2!
Kun ohjelma on valmis, nimeä Main funktio MyMain-funktioksi ennen testaamista ja palautusta

HUOM 3!
Path-funktio pitää jättää ohjelmaan ja kun kirjoitat tiedostoon tai luet sieltä, niin
StreamWriter ja StreamReader muuttujien esittelyt pitää olla näin:

StreamWriter sw = new StreamWriter(Path("datat.txt"));
StreamReader sr = new StreamReader(Path("datat.txt"));
*/
namespace Projekti
{
    class MyProgram
    {
        static string Path(string filename)
        {
            return System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "../../../src/", filename);
        }

        public static void TulostaTiedot(double[] taulukko)
        {
            double summa = 0;
            double min = taulukko[0];
            double max = taulukko[0];
            for (int i = 0; i < 40; i++)
            {
                summa += taulukko[i];
                if (taulukko[i] < min)
                {
                    min = taulukko[i];
                }
                if (taulukko[i] > max)
                {
                    max = taulukko[i];
                }
            }
            Console.WriteLine("SUMMA : " + Math.Round(summa, 1));
            Console.WriteLine("KA    : " + Math.Round(summa / 40, 1));
            Console.WriteLine("MIN   : " + min);
            Console.WriteLine("MAX   : " + max);
        }

        public static void LueTiedostosta(double[] taulukko)
        {
            StreamReader sr = new StreamReader(Path("datat.txt"));
            for (int i = 0; i < 40; i++)
            {
                taulukko[i] = double.Parse(sr.ReadLine());
            }
            sr.Close();
        }

        public static void ArvoJaTallennaTiedostoon()
        {
            StreamWriter sw = new StreamWriter(Path("datat.txt"));
            Random rnd = new Random();
            for (int i = 0; i < 40; i++)
            {
                double luku = Math.Round(rnd.NextDouble() * (5.8 - 1.4) + 1.4, 1);
                sw.WriteLine(luku);
            }
            sw.Close();
        }

        public static void MyMain()
        {
            double[] taulukko = new double[40];

            ArvoJaTallennaTiedostoon();
            LueTiedostosta(taulukko);
            TulostaTiedot(taulukko);
        }
    }
}