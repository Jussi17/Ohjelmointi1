using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Luo 7 alkioinen float-taulukko ja lue siihen käyttäjältä arvoja. Kun käyttäjä syöttää arvoa 
taulukkoon, niin ohjelma ei saa kaatua vaan väärä arvo on kysyttävä uudestaan. 
Lajittele taulukko ja tulosta taulukon minimi- ja maksimiarvot yhden desimaalin
tarkkuudella seuraavasti:

MIN : 12.3
MAX : 34.9


Käytä funktioita:

LuoTaulukko         : funktio palauttaa luodun taulukon
KysyArvotTaulukkoon : funktio saa parametrina taulukon
LajitteleTaulukko   : funktio saa parametrina taulukon
TulostaTiedot       : funktio saa parametrina taulukon

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
        public static void LuoTaulukko(out float[] luvut)
        {
            luvut = new float[7];
        }

        public static void KysyArvotTaulukkoon(float[] luvut)
        {
            for (int i = 0; i < luvut.Length; i++)
            {
                while (true)
                {
                    Console.Write("Anna arvo taulukon alkiolle {0}: ",i+1);
                    if (float.TryParse(Console.ReadLine(), out float arvo))
                    {
                        luvut[i] = arvo;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Virheellinen syöte. Anna liukuluku.");
                    }
                }
            }
        }

        public static void LajitteleTaulukko(float[] luvut)
        {
            Array.Sort(luvut);
        }

        public static void TulostaTiedot(float[] luvut)
        {
            float min = luvut[0];
            float max = luvut[luvut.Length - 1];
            Console.WriteLine("MIN : {0:F1}",min);
            Console.WriteLine("MAX : {0:F1}",max);
        }


        public static void MyMain()
        {
            float[] arvot;

            LuoTaulukko(out arvot);

            KysyArvotTaulukkoon(arvot);

            LajitteleTaulukko(arvot);

            TulostaTiedot(arvot);
        }
    }
}