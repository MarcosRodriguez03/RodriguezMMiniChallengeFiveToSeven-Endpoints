
using Microsoft.AspNetCore.Mvc;
using RodriguezMMiniChallengeFiveToSeven_Endpoints.ReverseItAlpha;
using RodriguezMMiniChallengeFiveToSeven_Endpoints.ReverseItNum;


namespace RodriguezMMiniChallengeFiveToSeven_Endpoints.Controllers;

[Route("[controller]")]
public class ReverseItNum : Controller
{
    private readonly IReverseNum _reverseNum;

    public ReverseItNum(IReverseNum reverseNum)
    {
        _reverseNum = reverseNum;
    }


    [HttpGet]
    [Route("enter number/{enterNum}")]
    public string wordMachine(string enterNum)
    {
        return _reverseNum.wordMachine(enterNum);
    }
}
