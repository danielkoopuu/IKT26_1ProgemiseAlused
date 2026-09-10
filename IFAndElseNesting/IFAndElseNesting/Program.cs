namespace IFAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If and else nesting ");
            //nesting tähendab ,et if else struktuuride 
            //sees võib olla teisi if else struktuure 
            //see võimaldab teha keeukamaid otsuseid ja 
            //kontrollida erinevaid tingimusi 

            int number = 11;
            if (number > 9)
            {
                //kui sisestan 9, siis see if else struktuur käivitub
                if(number == 11 )
                {
                    //kui sisestan 11 ,siis see if else struktuur käivitub
                    Console.WriteLine("number on 11");
                }
                else
                {
                    Console.WriteLine("vastus oli 0 kuni10 ja 12 kuni 19");
                }
            }
            else if ( number == 21)
            {
                Console.WriteLine("vastus oli 21");
            }
            else if (number == 21)
            {
                Console.WriteLine("vastus oli 30");
            }
            else
            {
                Console.WriteLine("mingi kahtlane number");
            }

        }
    }
}
