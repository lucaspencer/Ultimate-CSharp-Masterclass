
namespace DiceRollGame;

internal static class UserInput
{

    private static int _guess = 0;
    public static int Listen()
    {
        bool invalid = true;
        while (invalid)
        {
            Responder.Listening();
            string? input = Console.ReadLine();
            invalid = Validate(input);
        }
        return _guess;
    }

    private static bool Validate(string? input)
    {
        bool valid = int.TryParse(input, out _guess);
        if (!valid)
        {
            Responder.WrongInput();
            return true;
        }
        return false;
    }
}
