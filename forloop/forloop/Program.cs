namespace forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int loop = 10;
            // inti on muutjua määratlemine ja selle väärtus on 0
            // i < loop iga kord võrdleb loop muutuja , et kes on suurem ist
            //i++ liidab iga kord ühe korra juurde e sama hea , kui i + 1
            for (int i = 0; i < loop i++)
            {
                Console.WriteLine("loop " + i);
                Thread.Sleep(1000);
                Console.Beep();

                

              
            }

        }
    }
}
