
using Microsoft.AspNetCore.Mvc;
using RodriguezMMiniChallengeFiveToSeven_Endpoints.OddOrEven;


namespace RodriguezMMiniChallengeFiveToSeven_Endpoints.Controllers;

[Route("[controller]")]
public class OddOrEven : Controller
{
    private readonly IOddOrEven _oddOrEvenService;

    public OddOrEven(IOddOrEven oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }

    [HttpGet]
    [Route("OddOrEven/{enterNum}")]
    public string OddOrEvenMachine(string enterNum)
    {
        return _oddOrEvenService.OddOrEvenMachine(enterNum);
    }
}
