using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
tee ohjelma, joka tulostaa ensin tiedon siitä, kuinka monta parametria Main-funktioon tuli seuraavalla tavalla.

parametreja tuli 2 kpl

Lisäksi jos ensimmäisen parametri oli "opettaja" niin tulosta "koita saada opiskelijat oppimaan", 
jos se taas oli "opiskelija", niin tulosta "koita opiskella ahkerasti". Jos se oli jotain muuta, 
niin tulosta "nyt en hiffannut"
*/
namespace Projekti
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("parametreja tuli {0} kpl",args.Length);

            if (args.Length > 0)
            {
                if (args[0] == "opettaja")
                {
                    Console.WriteLine("koita saada opiskelijat oppimaan");
                }
                else if (args[0] == "opiskelija")
                {
                    Console.WriteLine("koita opiskella ahkerasti");
                }
                else
                {
                    Console.WriteLine("nyt en hiffannut");
                }
            }
        }
    }
}