using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Tee ohjelma, joka laskee mäkihyppääjän yhden kierroksen suorituspisteet. Ohjelma kysyy hypyn pituuden 
(liukuluku 0.5 metrin välein ja pituuden oltava > 0) sekä viiden arvostelutuomarin tyylipisteet (0-20 välillä 0.5 välein eli 
esim. 16.5 tai 17.0 tai 18.5). Vinkki. Jakojäännöksellä saa tutkittua onko puolen pisteen/metrin välein

Hyppääjän pisteet muodostuvat kaavasta.

pisteet = (hypyn pituus - kriittinen piste) * 1.8 + kolmen keskimmäisen tuomarin tyylipisteet + 60. 

Tyylipisteissä siis parhain ja huonoin pistemäärä tipahtaa pois.

Ohjelman hyppyrimäen kriittinen piste on 90 metrin kohdalla. Laita kriittinen piste vakioon KR_PISTE. 
Tulosta lopuksi hypyn pituus ja hypyn pisteet yhden desimaalin tarkkuudella seuraavalla tavalla.

PITUUS  : 115,5 m
PISTEET : 161,4

Käytä ohjelmassa funktioita (funktiot eivät saa palauttaa mitään ja kun käytät viittauksia, niin pitää
käyttää out-viittausta):

KysyHypynPituus
KysyTuomareidenPisteet
LaskeHypynPisteet
Tulosta

HUOM 1!
Kaikkien funktioiden otsikkorivien eteen on laitettava public. Esimerkiksi
public static void MyMain()

HUOM 2!
Kun ohjelma on valmis, nimeä Main funktio MyMain-funktioksi ennen testaamista ja palautusta
*/
namespace Projekti
{
    class MyProgram
    {
        public const int KR_PISTE = 90;
        public static void KysyHypynPituus(out double pituus)
        {
            while (true)
            {
                Console.Write("Anna hypyn pituus 0,5m tarkkuudella: ");
                if (double.TryParse(Console.ReadLine(), out pituus) && pituus > 0 && (pituus * 10) % 5 == 0)
                {
                    break;
                }
                Console.WriteLine("Virheellinen syöte. Syötä positiivinen liukuluku 0,5m tarkkuudella.");
            }
        }

        public static void KysyTuomareidenPisteet(out double[] pisteet)
        {
            pisteet = new double[5];
            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.Write("Anna tuomarin {0} pisteet (0-20 -> 0,5 välein): ",i+1);
                    if (double.TryParse(Console.ReadLine(), out double piste) && piste >= 0 && piste <= 20 && (piste * 10) % 5 == 0)
                    {
                        pisteet[i] = piste;
                        break;
                    }
                    Console.WriteLine("Virheellinen syöte. Syötä luku välillä 0-20 -> 0,5 välein.");
                }
            }
        }

        public static void LaskeHypynPisteet(double pituus, double[] pisteet, out double kokonaispisteet)
        {
            double[] keskimmäisetPisteet = pisteet.OrderBy(x => x).Skip(1).Take(3).ToArray();

            double tyylipisteet = keskimmäisetPisteet.Sum();

            kokonaispisteet = (pituus - KR_PISTE) * 1.8 + tyylipisteet + 60;
        }

        public static void Tulosta(double pituus, double kokonaispisteet)
        {
            Console.WriteLine("PITUUS  : {0:F1} m",pituus);
            Console.WriteLine("PISTEET : {0:F1}",kokonaispisteet);
        }

        public static void MyMain()
        {
            double pituus;
            double[] tuomariPisteet;
            double kokonaispisteet;

            KysyHypynPituus(out pituus);

            KysyTuomareidenPisteet(out tuomariPisteet);

            LaskeHypynPisteet(pituus, tuomariPisteet, out kokonaispisteet);

            Tulosta(pituus, kokonaispisteet);
        }
    }
}