namespace yesgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta sõna");
            string word = Console.ReadLine();
            
            
                 word = "";

                while (word != "yes")
                {
                    Console.WriteLine("Sisesta sõna:");
                    word = Console.ReadLine();
                }

                Console.WriteLine("Tubli! Sisestasid yes!");

        }
    }//while ja nii kaua tsükkel kestab kuni kasutaja sisestab sõna yes  
}
