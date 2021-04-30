using System;

namespace The_Big_bio_project
{
    class Program
    {

        static void Main(string[] args)
        {

            int ans;     





            string name;     
            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ".");
            Console.WriteLine("Here, let's wee how good you are at math.");
            Console.WriteLine("Let's starts simple, what is 6x8?"); 
            ans = Convert.ToInt32( Console.ReadLine() );

            if (ans == 48){
                Console.WriteLine("Correct!!");

            }
            else if (ans != 48) {
                Console.WriteLine("Wrong!");
            }




             





            
            Console.ReadKey();
        }
    }
}
