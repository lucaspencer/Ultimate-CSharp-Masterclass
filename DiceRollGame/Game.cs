namespace DiceRollGame;

public class Game
{
    readonly Die _die;
    public Game(Die die) { _die = die; }
    int _lives = 3;


    public GameOutcome Play()
    {
        _die.Roll();
        Responder.Welcome();

        while (_lives > 0)
        {
            bool isCorrect = UserInput.Check(UserInput.Listen(), _die); //this could be condensed into the if statement but readability suffers
            if (isCorrect) { _lives = 0; return GameOutcome.Win; }
            else
            {
                _lives--;
                Responder.BadGuess();
            }
        }
        return GameOutcome.Loss;
    }

    public enum GameOutcome
    {
        Win,
        Loss
    }
}

