

namespace DiceRollGame;

internal class Program
{
    static void Main(string[] args)
    {
        int lives = 3;
        Die.Roll();
        Responder.Welcome();

        while (lives > 0)
        {
            bool isCorrect = Guess.Check(UserInput.Listen()); //this could be condensed into the if statement but readability suffers
            if (isCorrect) { lives = -1; }
            else 
            {
                lives--;
                Responder.BadGuess();
            }
        }
        Responder.Goodbye(lives);
        Console.ReadLine();
    }
}
