
namespace RodriguezMMiniChallengeFiveToSeven_Endpoints.OddOrEven;

public class OddOrEvenService : IOddOrEven
{
    public string OddOrEvenMachine(string enterNum)
    {

        int num2 = 0;
        bool isTrue = int.TryParse(enterNum, out num2);

        if (isTrue)
        {

            if (num2 % 2 == 0)
            {
                return $"{num2} is even";
            }
            else
            {
                return $"{num2} is odd";
            }



        }
        else
        {
            return "enter a valid whole number";
        }


    }
}
