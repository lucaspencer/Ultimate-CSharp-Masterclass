
namespace DiceRollGame;

public class Die 
{
    readonly Random _randomiser;
    const int _sides = 6;

    public int LastRoll { get; private set; }

    public int Roll()
    {
        int face = _randomiser.Next(1, _sides + 1);
        LastRoll = face;
        return face;
    }

    public Die(Random random)
    {
        _randomiser = random;
    }
}
