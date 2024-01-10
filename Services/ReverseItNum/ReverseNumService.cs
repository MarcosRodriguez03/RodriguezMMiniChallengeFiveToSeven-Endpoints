
namespace RodriguezMMiniChallengeFiveToSeven_Endpoints.ReverseItNum
{
    public class ReverseNumService : IReverseNum
    {
        public string wordMachine(string enterNum)
        {
            double num2 = 0;
            bool isTrue = double.TryParse(enterNum, out num2);

            if (isTrue)
            {
                string newNum = "";
                for (int i = enterNum.Length - 1; i >= 0; i--)
                {
                    newNum += enterNum[i];
                }
                return $"You entered {enterNum}, reversed is {newNum}";
            }
            else
            {
                return "enter a valid number";
            }
        }
    }
}