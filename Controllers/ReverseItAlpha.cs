
using Microsoft.AspNetCore.Mvc;
using RodriguezMMiniChallengeFiveToSeven_Endpoints.ReverseItAlpha;


namespace RodriguezMMiniChallengeFiveToSeven_Endpoints.Controllers;

[Route("[controller]")]
public class ReverseItAlpha : Controller
{
    private readonly IReverseAlpha _reverseItAlpha;

    public ReverseItAlpha(IReverseAlpha reverseItAlpha)
    {
        _reverseItAlpha = reverseItAlpha;
    }


    [HttpGet]
    [Route("enterWord/{enterWord}")]

    public string reverseMachine(string enterWord)
    {
        return _reverseItAlpha.reverseMachine(enterWord);
    }

}
