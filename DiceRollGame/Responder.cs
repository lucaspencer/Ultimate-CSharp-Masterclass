

namespace DiceRollGame;

internal static class Responder
{
    public static void Welcome() => Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

    public static void WrongInput() => Console.WriteLine("Incorrect Input.");
    
    public static void Listening() => Console.WriteLine("Enter number: ");

    public static void Goodbye(int lives)
    {
        switch (lives)
        {
            case 0:
                Console.WriteLine("You lose");
                break;
            case -1:
                Console.WriteLine("You win");
                break;
        }
    }

    public static void BadGuess() => Console.WriteLine("Wrong Number");
}
