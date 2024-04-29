
namespace DiceRollGame;


internal static class Responder
{
    public static void Welcome() => Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

    public static void WrongInput() => Console.WriteLine("Incorrect Input.");
    
    public static void Listening() => Console.WriteLine("Enter number: ");

    public static void Goodbye(Game.GameOutcome result)
    {
        string message = result == Game.GameOutcome.Win 
            ? "You win" : "You lose";

        Console.WriteLine(message);
    }

    public static void BadGuess() => Console.WriteLine("Wrong Number");
}
