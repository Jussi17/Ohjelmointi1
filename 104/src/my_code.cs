using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Esittele nimi, pituus ja paino muuttujat. Esittele lisäksi bmi muuttuja.
Kysy käyttäjältä nimi, pituus metreinä ja paino kilon tarkkuudella.
Laske painoindeksi bmi muuttujaan seuraavasti:

bmi = paino / pituus ^ 2

Tulosta lopuksi:

Olli Opiskelija, pituutesi on 1,81 m ja painosi 104 kg
Painoindeksisi on siten 31,75
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            string sNimi;
            float fPituus, fBmi;
            int iPaino;

            Console.Write("Anna nimesi: ");
            sNimi = Console.ReadLine();

            Console.Write("Anna pituutesi metreissä: ");
            fPituus = float.Parse(Console.ReadLine());

            Console.Write("Anna painosi  kilon tarkkuudella: ");
            iPaino = int.Parse(Console.ReadLine());

            fBmi = (float)iPaino / (float)Math.Pow(fPituus, 2);

            Console.WriteLine("{0}, pituutesi on {1} m ja painosi {2} kg\nPainoindeksisi on siten {3:F2}",sNimi,fPituus,iPaino,fBmi);
        }
    }
}

