using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Esittele kaksi kokonaislukumuuttujaa ja lue niihin käyttäjältä arvot.
Tulosta näiden muuttujien summa, erotus ja tulo alla olevalla tavalla
(HUOM! Laskutoimituksen tulostus alkaa kaikissa samasta kohdasta!)

Summa :  10 + 5 = 15
Erotus : 10 - 5 = 5
Tulo :   10 * 5 = 50
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int num1, num2;

            Console.Write("Anna ensimmäinen kokonaisluku: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Anna toinen kokonaisluku: ");
            num2 = int.Parse(Console.ReadLine());

            int iSumma = num1 + num2;
            int iErotus = num1 - num2;
            int iTulo = num1 * num2;

            Console.WriteLine("Summa :  " + num1 + " + " + num2 + " = " + iSumma);
            Console.WriteLine("Erotus : " + num1 + " - " + num2 + " = " + iErotus);
            Console.WriteLine("Tulo :   " + num1 + " * " + num2 + " = " + iTulo);
        }
    }
}
