namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let`s play a guessing game!");
            Console.WriteLine("Now, let`s choose a limit range of the number:");

            var number = Console.ReadLine();
            var userInput = int.Parse(number);
            var r = new Random();
            var favNumber = r.Next(1, userInput);

            Console.WriteLine("Try to guess the number:");
            var guess = int.Parse(Console.ReadLine());

           
            if (guess > favNumber)
            {
                Console.WriteLine("Too high!Let`s Try it one more time");
                guess = int.Parse(Console.ReadLine());
                if (guess != favNumber)
                {
                    Console.WriteLine("Sorry, you lost.");
                }
            }
            else if (guess < favNumber)
            {
                Console.WriteLine("Too low! One more change.");
                guess = int.Parse(Console.ReadLine());
                if (guess != favNumber)
                {
                    Console.WriteLine("Sorry, you lost.");
                }
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            Console.ReadLine();
        }

    
    }
}
