namespace FORPRIMENUMBER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //sisestad numbri
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = number >  1;
            //for loopiga käib kontroll, kas on algarv 
            //if ja else annavad vastuse , kas on algarv või mite 
        
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            
            if (isPrime)
            {
                Console.WriteLine("Arv on algarv!");
            }
            else
            {
                Console.WriteLine("Arv ei ole algarv!");
            } 
        }
    }
}
