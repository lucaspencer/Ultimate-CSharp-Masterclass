
namespace DiceRollGame;

internal static class Die 
{
    static readonly Random _randomiser = new();
    public static int LastRoll { get; private set; }

    public static int Roll()
    {
        int face = _randomiser.Next(1, 7);
        LastRoll = face;
        return face;
    }
}
