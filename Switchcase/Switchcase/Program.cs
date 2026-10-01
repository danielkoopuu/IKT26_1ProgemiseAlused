namespace Switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta täht ja vajuta enter");
            string character = Console.ReadLine();
            switch (character)
            {
                case "a":
                    Console.WriteLine("Sisestasid tähe a");
                    break;
                case "b":
                    Console.WriteLine("sisestatud tähe b");
                    break;
                default:
                    Console.WriteLine("sisestasid mõnda muud tähte");
                    break;
                    
                
            }   
        }

    }
}
