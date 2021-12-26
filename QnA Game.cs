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
            Console.WriteLine("What is the best film in the world");
            string name = Console.ReadLine();
            
            if (name == "Lord of the rings")
            {
                Console.WriteLine("Correct");
            }
            //this is the chance to give after every wrong answer
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

            //this space to get gap between question and answer
            
            
            Console.WriteLine("Who is the best human in the world");
            string answer = Console.ReadLine();

            //this is the answer

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
