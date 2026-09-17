using System.Numerics;

namespace IfAndElseFootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere Daniel");


        

            Console.WriteLine("sisesta jalanumber");

            string footnumber = Console.ReadLine();
            int foot = int.Parse(footnumber);
            if (foot >= 30 && foot <= 33 )
            {
                Console.WriteLine("jalanumber on 30 kuni 33");
            }
            else if (foot >= 34 && foot <= 38)
            {
                Console.WriteLine(" jalanumber on 34 kuni 38");
            }
            else if (foot >= 39 && foot <= 44)
            {
                Console.WriteLine("jalanumber on 39 kuni 44");
            }
            else if (foot >= 45 && foot <= 48 )
            {
                Console.WriteLine("jalanumber on 45 kuni 48");
            }
            else
            {
                Console.WriteLine("sinu jalanumber on väga suur või vaike ");
            }

        }


        
        
    }
}
