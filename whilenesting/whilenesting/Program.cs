namespace whilenesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //tuleb kasutada while ja omakorda while while sisse panna 
            //while nesting 
            //while kordab 5 korda
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine(" tsükkel: " + i);

                int j = 1;

                while (j <= 3)
                {
                    Console.WriteLine(" tsükkel: " + j);
                    j++;
                }

                i++;
            }
             


        }
    }
}
