using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Esittele kaksi laskurimuuttujaa ja tulosta niiden avulla for-silmukassa:

11       10
12       9
13       8
...
19       2
20       1

Eli toinen arvo toisesta muuttujasta ja toinen toisesta ja
tabulointimerkki lukujen välissä
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            for (int i = 11, j = 10; i <= 20; i++, j--)
            {
                Console.WriteLine("{0}\t{1}", i, j);
            }
        }
    }
}

