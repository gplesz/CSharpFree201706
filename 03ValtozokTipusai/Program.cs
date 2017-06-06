using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ValtozokTipusai
{
    class Program
    {
        static void Main(string[] args)
        {
            var szam = 1;

            var szoveg = "ez egy szöveg";

            //Ez ugyanaz,
            var szam2 = 2;

            ////mint ez
            //int szam2 = 2;
            ////vagy ez:
            //int szam2;
            //szam2 = 2;


            var szam3 = 2 + 3;

            //Figyelem, amikor létrejött egy sárga cetli, onnantól az ő útja meg van határozva.
            //csak a saját útját járhatja, másét nem:

            //mivel változó, ezért átírhatom az értékét
            szam = 4;

            //egymásnak is tudnak értéket adni:
            szam2 = szam + szam3;

            //Ez viszont lehetetlen:
            //szam = "ez egy szöveg";
            //szoveg = 3;
            //mivel más műveleteknek van értelme egy számon és egy szövegen
            //számokat el tudok osztani egymással, szövegeket például nem

            //MIlyen típusok vannak?
            //számok (egész, tizedestört, stb...
            //szöveg
            //logikai (igaz/hamis: true/false)

            var igaz = true;
            var hamis = false;

            //Dátum/Idő: DateTime

            szam2 = Osszeadas(szam, szam3);

            var szam4 = Osszeadas(4, 6);
            szam4 = Osszeadas(1, 5);
            szam4 = Osszeadas(szam, 5);
            szam4 = Osszeadas(szam, Osszeadas(szam2, 5)); //Számold ki
            //A szam2 és az 5 értékét
            //Az így számolt értéket használd a második összeadás második paramétereként, 
            //az első legyen a szam nevű cetli.

        }

        private static int Osszeadas(int szam1, int szam2)
        {
            var szam0 = szam1 + szam2;
            return szam0; //ez jelenti azt, hogy visszatérünk a return után következő értékkel.
        }
    }
}
