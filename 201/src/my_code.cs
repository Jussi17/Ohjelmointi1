using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä koenumero 4-10 väliltä. Jos käyttäjä syötti arvosanan väärin,
niin tulosta "et antanut arvosanaa annetulta väliltä". Muussa tapauksessa tulosta:

"hyvä", jos arvosana oli 9 tai 10
"kelpo", jos 7-8
"tyydyttävä", jos 5-6
"heikko", jos 4

Toteuta ohjelma if-rakenteella
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.Write("Anna arvosana 4-10: ");
            int iNumero = int.Parse(Console.ReadLine());

            if (iNumero < 11 && iNumero > 8)
            {
                Console.WriteLine("hyvä");
            }
            else if (iNumero < 9 && iNumero > 6)
            {
                Console.WriteLine("kelpo");
            }
            else if (iNumero < 7 && iNumero > 4)
            {
                Console.WriteLine("tyydyttävä");
            }
            else if (iNumero == 4)
            {
                Console.WriteLine("heikko");
            }
            else
            {
                Console.WriteLine("et antanut arvosanaa annetulta väliltä");
            }
        }
    }
}
