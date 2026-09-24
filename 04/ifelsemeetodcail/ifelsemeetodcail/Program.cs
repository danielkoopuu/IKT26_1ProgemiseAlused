namespace ifelsemeetodcail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere Daniel");
            //meil on meetod mis läheb alati esimesena tööle 
            //teha siia teine meetod ja nimeks on sellel he
            Hellomeethod();
            terehommikust();
            Console.WriteLine( "kui soovid meetotit välja kutsuda siis kirjuta ja");
            string method = Console.ReadLine();

            if (method == "ja")
            {        // kui kirjutan meetodi nime siis seda nimetatakse 
                //meetodi välja kutsumiseks 
                hellomethod();
            }
            else
            {
                Console.WriteLine("ei soovinud midagi");
            }
        }
        static void Hellomeethod()
        {
            Console.WriteLine("Hello kitty");
        }
       
    }
}
