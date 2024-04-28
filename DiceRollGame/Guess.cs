

namespace DiceRollGame;

internal static class Guess
{
    public static bool Check(int input)
    {
        if (input == Die.LastRoll) { return true; }
        return false;
    }
}
