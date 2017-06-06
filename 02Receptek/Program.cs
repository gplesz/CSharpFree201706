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

            //Lépésekre bontjuk a bonyolult részt
            //változó: sárga (radírozható!) cetli (postit)
            //változó angolul: variable, rövidítve: var

            //létrehozunk egy maiNap nevű cetlit
            var maiNap = DateTime.Today; //egy lépésben írunk is rá
                                         //az írás az mindig "jobbról balra" történik
                                         //vagyis, mindig az egyenlőségjel baloldalán álló
                                         //"cetli"-re írjuk azt, ami a jobboldalon van.

            //a mai nap az a hétnek melyik napja:
            var maiNapNeve = maiNap.DayOfWeek;

            //melyik napon van hal a piacon:
            //var maVanHalAPiacon = DayOfWeek.Tuesday; //ezt a sort kell használni, ha kedden jön a hal
            var maVanHalAPiacon = DayOfWeek.Friday; //ezt a sort kell használni, ha pénteken.

            AMegfeleloReceptKiiratasa(maiNapNeve, maVanHalAPiacon);

            Console.ReadLine();
        }

        private static void AMegfeleloReceptKiiratasa(DayOfWeek maiNapNeve, DayOfWeek maVanHalAPiacon)
        {
            //if (DateTime.Today.DayOfWeek==DayOfWeek.Tuesday) //ezt a sort erre tujuk cserélni:
            if (maiNapNeve == maVanHalAPiacon)
            { //ha péntek van, akkor ez történik
                HalasReceptKiirasa();
            }
            else
            { //minden más esetben pedig ez
                PorkoltReceptKiiratasa();
            }
        }

        /// <summary>
        /// Halas recept kiíratása a konzolra
        /// 
        /// </summary>
        private static void HalasReceptKiirasa()
        {
            Console.WriteLine("Valamilyen halas étel recept hozzávalók");
        }


        /// <summary>
        /// Egy pörkölt recept kiírását végző függvény
        /// 
        /// private (private/internal/public): honnan látható? 
        ///         (private: csak kódblokk)
        ///         (public: mindenhonnan)
        ///         (internal: csak az adott assemblyből (projektből))
        /// static: mivel static-ból hívjuk, ezért static-nak kell lennie.
        /// 
        /// void: nincs visszatérési érték a függvényből
        /// 
        /// </summary>
        private static void PorkoltReceptKiiratasa()
        {
            Console.WriteLine("Marhahús");
            Console.WriteLine("Vöröshagyma");
            Console.WriteLine("Olaj");
            Console.WriteLine("Pirospaprika");
        }
    }
}
