namespace whiletriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int rida = 1;

            while (rida <= 5)
            {
                Console.WriteLine(new string('*', rida));
                rida++;
            }
        }
    }
}
