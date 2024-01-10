
namespace RodriguezMMiniChallengeFiveToSeven_Endpoints.ReverseItAlpha;

public class ReverseAlphaService : IReverseAlpha
{
    public string reverseMachine(string enterWord)
    {

        string word = "";
        for (int i = enterWord.Length - 1; i >= 0; i--)
        {
            word += enterWord[i];
        }

        return $"You entered {enterWord}, reversed is {word}";


    }
}
