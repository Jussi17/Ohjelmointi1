using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Kysy käyttäjältä kuukauden numero.
Tulosta sen jälkeen onko nyt "syksy", "talvi", "kevät" vai "kesä".
Käytä switch-case rakennetta. Jos käyttäjä syötti kuukauden numeron väärin, niin tulosta
"et antanut kuukauden numeroa oikein"
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int iVastaus;
            Console.Write("Anna kuukauden numero: ");
            iVastaus = int.Parse(Console.ReadLine());

            switch (iVastaus)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("talvi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("kevät");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("kesä");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("syksy");
                    break;
                default:
                    Console.WriteLine("et antanut kuukauden numeroa oikein");
                    break;

            }
        }
    }
}

