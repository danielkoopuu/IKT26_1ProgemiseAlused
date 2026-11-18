namespace korrutus_tabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("korrutustabel!");

            int j, i, n;
            Console.WriteLine("sisesta tabelise number , mis on viimane korrutis");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            //kaks for loopi ja üks on teise sees
            for (i = 1; i <= 10; i++)
            {
                for (j = 1;j <= n; j++)
                {
                    if (i <= n - i)
                    {
                        Console.Write("{0}x{1} = {2}", j,i,i*j);
                    }
                    else
                    {
                        Console.Write("{0}x{1} = {2}", j, i, i * j);
                    }
                    Console.Write("\n");
                }
                

                
            }
        }
    }
    
}
