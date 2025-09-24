using System;
namespace Module4Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dad Jokes Generator");
            Console.WriteLine("Here's random dad jokes we already have ");
            // Declare an array with 12 dad jokes
            string[] dadjokes = new string[]{
                "I had a quiet game of tennis today. There was no racket.",
                "What did one slice of bread say to the other before the race? You're toast!",
                "I poured some water over a duck's back yesterday. I don't think he cared.",
                "Watch what you say around the egg whites. They can't take a yolk.",
                "I went to the aquarium this weekend, but I didn’t stay long. There’s something fishy about that place.",
                "I asked my dog what’s two minus two... He said nothing",
                "I gave all my dead batteries away today... Free of charge.",
                "Why don’t programmers like nature? It has too many bugs",
                "What did the wall say to the other wall? I'll meet you at the corner.",
                "How did the barber win the race? he knew a shortcut.",
                "My boss told me to have a good day, so I went home.",
                "Want to hear a long joke? Jooooooooooooooke"


            };

            // create random object
            Random rnd = new Random();
            int month = rnd.Next(1, 13);
            // Ask loop starts here 
            string answer = "yes";
            while (answer.ToLower() == "yes")
            {
                int firstIndex = rnd.Next(dadjokes.Length);
                int secondIndex;
                do
                {
                    secondIndex = rnd.Next(dadjokes.Length);

                }
                while (secondIndex == firstIndex);
                //show jokes
                Console.WriteLine("Here are two random dad jokes:\n");
                Console.WriteLine("1." + dadjokes[firstIndex]);
                Console.WriteLine("2. " + dadjokes[secondIndex]);
                //ask user
                Console.WriteLine("\n Do you want to see more dad jokes? (Yes/No)");
                answer = Console.ReadLine();

            }//End while loop
            Console.WriteLine("\n Thnaks for laughing! Goodbye!");

       }//End main 
    }// End class
}//End namespace