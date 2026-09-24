namespace ifElseautod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere Tulemast meie auto poodi ");
            Console.WriteLine("Valikus on Bmw,audi , porsche, fiat ja skoda ");
            //kasutada if ja else 
            //kirjuta automark
            //valikus on bmw, audi ,porsche , fiat ja skoda
            //kui valitakse skoda, siis seal sees on uuesti küsimus, et 
            //mis mudelit soovid valida. mudeli valikus kodiaq ja octavia 

            string car = Console.ReadLine();
            if (car == "Bmw")
            {
                Console.WriteLine(" olete valinud Bmw auto");
            }
            else if (car == "audi")
            {
                Console.WriteLine("olete valinud audi auto ");
            }
            else if (car == "porsche")
            {
                Console.WriteLine("olete valinud porsche auto");
            }
            else if (car == "fiat")
            {
                Console.WriteLine("olete valinud fiat auto ");
            }
            else if (car == "skoda")
            {
                Console.WriteLine("olete valinud skoda");
                Console.WriteLine("millist mudelit teie tahata");
                Console.WriteLine("valikus on kodiaq ja octavia");

                string carmodule = Console.ReadLine();

                if (carmodule == "kodiaq")
                {
                    Console.WriteLine("olete valinud kodiaq mudelit");
                    Console.WriteLine("Headaega");
                }
                else if (carmodule == "octavia")
                {
                    Console.WriteLine("olete valinud octavia mudelit");
                    Console.WriteLine("Headaega");
                }
            }
            else
            {
                Console.WriteLine("siukest autot meil pole kahjuks müügis");
            }

            
           
            
 
             
        } 



    }
}
