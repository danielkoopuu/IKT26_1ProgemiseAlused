using System.Security.Cryptography;
using System.Xml;

namespace IfElseColour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha if ja else konsoolirakendus, kus" + 
                "kontrollitakse stringi abil värvi vastavust ");

            Console.WriteLine("värvide valikuks on : red, blue , green ja white");

            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta " +
                "eelpool sisestatud värvi");

            Console.WriteLine("sisesta värv");
            //kirjuta konsooli tekst ja vajuta enter 
            string color = Console.ReadLine();
            //see kontrollib kas punane värv 
           //kui kasutad if ja else esimene ontroll on if ja järgneb siis else if ja kõige viimane else 

            if (color == "red")
            {
                Console.WriteLine( "see on punane ");
            }
            else if (color == "blue")
            {
                Console.WriteLine("see on sinine");


            }
            else if (color == " green")
            {
                Console.WriteLine("See on roheline" );
            }
            else if (color == "white")
            {
                Console.WriteLine("see on valge");
            }
            else
            {
                Console.WriteLine("kahtlane värv");
            }
            
            
            
            
        }
        
    }
}
