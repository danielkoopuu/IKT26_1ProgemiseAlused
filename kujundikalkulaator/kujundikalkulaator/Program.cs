namespace kujundikalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double raadius = 3;
            double kylg = 2 * raadius;

            double pindala = kylg * kylg;
            double umbermoot = 4 * kylg;
   

            Console.WriteLine("Ruudu pindala: " + pindala);
            Console.WriteLine("Ruudu ümbermõõt: " + umbermoot);

            //ruudu sees asub ring . ringi raadius on 3 ühikut 
            //leia ja väljasta ekraail ruudu pindala ja ümbermõõt

            //arvuta ringi pindala ja ümbermõõt
            double ringiPindala = Math.PI * raadius * raadius;
            double ringiUmbermoot = 2 * Math.PI * raadius;

            Console.WriteLine("Ringi pindala: " + ringiPindala);
            Console.WriteLine("Ringi ümbermõõt: " + ringiUmbermoot);
       
        }
    }
}
