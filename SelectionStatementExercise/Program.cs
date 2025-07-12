namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var favNum = random.Next(1, 10);
            int response = 0;



            while (response != favNum)
            {
                Console.WriteLine("Give me a number between 1 and 10:");
                response = int.Parse(Console.ReadLine());




                if (response < favNum)
                {
                    Console.WriteLine($"Too low!\nYour guess: {response}.");
                }
                else if (response > favNum)
                {
                     Console.WriteLine($"Too high!\nYour guess: {response}.");
                }
                
                else
                {
                    Console.WriteLine($"You guessed it!\nThe favorite number was {favNum}.");
                }
                
            }
        }
    }
}
