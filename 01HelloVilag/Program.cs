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


            //Ez a sor ugyanaz, mint a lenti!!!
            Console.WriteLine("Hello innen a NetAcademia C# tanfolyamból!");
            
            Console       //Ahol pont van a kódban, ott lehet szóköz is
                
                          //ahol szóköz van a kódban, ott lehet soremelés (enter) is
                
                          //Ahol enter lehet, ott tetszőleges számú enter is lehet egymás után
                
                .      
                
                
                
                
                WriteLine(      //Ahol idézőjel nyitűs van, ott is lehet szóköz,
                
                                //és így enter is
                
                "Hello innen a NetAcademia C# tanfolyamból!"    
                
                
                                //ugyanígy a záró zárójel előtt
                
                
                );              //ezért jelezni kell a "gondolat" végét, méghozzá pontosvesszővel
        }
    }
}
