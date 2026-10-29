namespace maakalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tere !");
            //meil on münt, mille diameeter on 25.75mm
            //arvutada välja Maa ümbermõõt ja mitu münti 
            //mahub järjestiku ümber maa 
            //arvutuses tohib kasutada ainult münti diameetrit ja maa raadiust

            double coindiameter = 25.75; //mm 
            double earthradius = 6378000000;
            double aroundtheEarth = 2 * Math.PI * earthradius;
            double howmanycoins = aroundtheEarth / coindiameter;
            Console.WriteLine(aroundtheEarth);

            Console.WriteLine (howmanycoins);
        }
    }
}
