namespace IfAndElsenesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere Daniel");

            string number = Console.ReadLine();
            //muudmae stringi andmetüüpiks ja kasutame parset
            int numberInt = int.Parse(number);

            if (numberInt == 12)
            {
                Console.WriteLine("number on 12 ");
            }
            else if (numberInt > 20)
            {
                if (numberInt > 30)
                {
                    Console.WriteLine("Sinu vanus on 31 või vanem");
                }
                else
                {
                    Console.WriteLine("Sinu vanus on 21 kuni 30 ");
                }
                
            }
            else
            {
                Console.WriteLine("Mingid kahtlased väärtused");
            }
        }
    }
}
