using System;

namespace first_project
{
    class Program
    {
        static void Main(string[] args)
        { 
            //this is to get the window title
            Console.Title = "quiz";
            
            //the question
            Console.WriteLine("What is the best cartoon trilogy in the world");
            string name = Console.ReadLine();

            if (name == "Oggy and the cockroaches")
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Wrong");
                Console.ReadLine();

                Console.WriteLine("You Have Other Chance"); 
                Console.ReadLine();
                  
                Console.WriteLine("Last chance");
                Console.ReadLine();
  
                Environment.Exit(1);
                
            }    

            
            
            
            Console.WriteLine("Who is the best human in the world");
            string answer = Console.ReadLine();

            
            if (answer == "elon musk")
            {
                Console.WriteLine("Correct");

            }
            else
            {
                Console.WriteLine("Wrong");
                Console.ReadLine();

                Console.WriteLine("You Have Other Chance"); 
                Console.ReadLine();
                  
                Console.WriteLine("Last chance");
                Console.ReadLine();

            }
                
                Console.ReadKey();
        }
    }
}