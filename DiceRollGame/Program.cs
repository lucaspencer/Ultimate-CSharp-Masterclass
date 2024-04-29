

using static DiceRollGame.Game;

namespace DiceRollGame;

internal class Program
{
    static void Main(string[] args)
    {
        Random random = new();
        Die die = new Die(random);
        Game game = new Game(die);

        GameOutcome result = game.Play();
        Responder.Goodbye(result);
        Console.ReadLine();
    }
}

