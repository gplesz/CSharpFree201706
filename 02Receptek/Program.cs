using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Receptek
{
    /// <summary>
    /// Legyen az a feladat, hogy egy pörkölt recept hozzávalóit kiírjuk a képernyőre
    /// 
    /// Kiegészítés: hetente egyszer érkezik hal a piacra, akkor halas ételt szeretnénk készíteni,
    /// egyébként pedig pörköltet 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            //ha (péntek van) akkor (halas recept) egyébként (pörkölt recept)

            //feltételvizsgálat:
            //
            //van két tevékenység
            //megnézünk egy információt, és attól függően
            //mit mutat az információ
            //vagy az egyik tevékenységet végezzük el
            //vagy a másikat
            //de egyszerre mindig csak az egyiket

            //ha (péntek van) 
            //akkor (halas recept) 
            //egyébként (pörkölt recept)

            //kódblokk: {} minden, ami két kapcsos zárójel (harcsabajusz) között van

            //

            //Ctrl+K majd Ctrl+C billentyűkombinációval 
            //több soros kijelölés küldhető megjegyzésbe
            //if (péntek van?) //ide kerül az információ vizsgálata
            //{ //kódblokk eleje
            //    //Ebbe a kódblokkba kerül az, 
            //    //amit akkor hajtunk végre, 
            //    //ha a vizsgálat igaz 
            //    //(a kérdésre a válasz az, hogy igen, a válasz: IGAZ (péntek van)
            //} //kódblokk vége
            //else
            //{ 
            //    //Ebbe a kódblokkba kerül az, 
            //    //amit akkor hajtunk végre, 
            //    //ha a vizsgálat eredménye hamis
            //    //(a kérdésre a válasz az, hogy nem, a válasz: HAMIS (nem péntek van)
            //}


            //a péntek van? kérdésre két lépésben tudunk válaszolni:

            //megkérdezzük a .NET-től, hogy milyen nap van ma?
            //majd megnézzük, hogy ez a nap péntek?

            //Ha két dolognak az egyenlőségét vizsgáljuk, akkor 
            //dupla egyenlőség jelet kell használnunk: ==

            //.NET-ben így kérdezzük le a mai napot: DateTime.Today
            //és az, hogy ez a dátum milyen nap a héten, azt pedig így kapjuk meg:
            //DateTime.Today.DayOfWeek

            if (DateTime.Today.DayOfWeek==DayOfWeek.Tuesday)
            { //ha péntek van, akkor ez történik
                Console.WriteLine("Valamilyen halas étel recept hozzávalók");
            }
            else
            { //minden más esetben pedig ez
                Console.WriteLine("Marhahús");
                Console.WriteLine("Vöröshagyma");
                Console.WriteLine("Olaj");
                Console.WriteLine("Pirospaprika");
            }

            Console.ReadLine();
        }
    }
}
