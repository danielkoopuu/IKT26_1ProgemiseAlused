using System.Threading.Channels;

namespace MAndElse

{// Projekt nimetusega IFAndElse, mille sees asub 
    //class nimega Program. See klass sisaldab Main meetodit 
    //mis on programmi sisenemispunkt.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta enda nimi");

            //muutuja nimega name, kuhu salvestatakse kasutaja
            //sisestatud tekst 
            string name = Console.ReadLine();
            //! tähendab" ei ole" ja == tähendab "on võrdne"

            if (name != "")
            {
                //kui kasutaja sisestab midagi,siis muudetakse taustavärv
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("sisestasid enda nime ");
                Console.WriteLine(name);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ERROR. nime ei sisestanud");
                //kui kasutaja ei sisesta midagi, siis kostub 2 piisku
                Console.Beep();
                //ja oodatakse 1 sekund enne programmi lõppu
                Thread.sleep (1000);
                Console.Beep();

            }
        }
    }
}
