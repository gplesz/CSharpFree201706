using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HelloVilag
{
    class Program
    {
        static void Main(string[] args)
        {
            // ez a sorközi megjegyzés jele, amit ezután írunk, a fordító figyelmen kívül hagyja

            /*  a többsioros megjegyzés jele a per-csillag és csillag per. Ami e
             *  két jel között van, az akárhány sor is, megjegyzésnek számít
             * 
             * 
             */

            //A C# Case Sensitive nyelv, megkülönbözteti a 
            //kis és nagybetűket! tehát:

            //ugyanúgy, ahogy nem írunk ilyet: kEdvES mAMa!
            //a C# -ban is a kis és nagybetű mást jelentenek.
            //tehát a 
            //         console 
            // nem azt jelenti amit a 
            //         Console
            //

            //Tehát ilyen sincs:
            //         console.writeline

            //Királynét megölni nem kell félnetek jó lesz
            //Királynét megölni nem kell, félnetek jó lesz
            //Királynét megölni, nem kell félnetek, jó lesz

            //Tehát: minden, ami látszik (nem szóköz és enter) annak fontos jelentése, nem elhagyható

            //Ez a sor ugyanaz, mint a lenti!!!
            Console.WriteLine("Hello innen a NetAcademia C# tanfolyamból!");
            
            Console       //Ahol pont van a kódban, ott lehet szóköz is
                
                          //ahol szóköz van a kódban, ott lehet soremelés (enter) is
                
                          //Ahol enter lehet, ott tetszőleges számú enter is lehet egymás után
                
                .      
                
                
                
                
                WriteLine(      //Ahol idézőjel nyitás van, ott is lehet szóköz,
                
                                //és így enter is
                
                "Hello innen a NetAcademia C# tanfolyamból!"    
                
                
                                //ugyanígy a záró zárójel előtt
                
                
                );              //ezért jelezni kell a "gondolat" végét, méghozzá pontosvesszővel
        }
    }
}
