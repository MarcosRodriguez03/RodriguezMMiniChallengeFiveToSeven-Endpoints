
namespace RodriguezMMiniChallengeFiveToSeven_Endpoints.MadLib;

public class MadLibService : IMadLib
{
    public string EnterHere(string enterNameOne, string enterNameTwo, string enterAdjectiveOne, string enterAdjectiveTwo, string enterAnimalOne, string enterAnimalTwo, string enterAnimalThree, string enterFood, string enterAdjectiveThree, string enterEvent)
    {
        return $"Once upon a time there was a boy named {enterNameOne}. {enterNameOne} and his friend {enterNameTwo} were getting ready for the zoo. The zoo is a {enterAdjectiveOne} place full of {enterAdjectiveTwo} animals. {enterNameTwo} was excited to see the {enterAnimalOne}, {enterAnimalTwo}, and {enterAnimalThree}. When they arrived at the zoo they saw zoo keepers feeding the lion {enterFood}. At the end of the day the two friends had a {enterAdjectiveThree} time, and had to leave to go to a/an {enterEvent}.";
    }
}
