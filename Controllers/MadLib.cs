
using Microsoft.AspNetCore.Mvc;
using RodriguezMMiniChallengeFiveToSeven_Endpoints.MadLib;

namespace RodriguezMMiniChallengeFiveToSeven_Endpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class MadLib : Controller
{
    private readonly IMadLib _madLibService;

    public MadLib(IMadLib MadLibService)
    {
        _madLibService = MadLibService;
    }

    [HttpGet]
    [Route("EnterHere/{enterNameOne}/{enterNameTwo}/{enterAdjectiveOne}/{enterAdjectiveTwo}/{enterAnimalOne}/{enterAnimalTwo}/{enterAnimalThree}/{enterFood}/{enterAdjectiveThree}/{enterEvent}")]

    public string EnterHere(string enterNameOne, string enterNameTwo, string enterAdjectiveOne, string enterAdjectiveTwo, string enterAnimalOne, string enterAnimalTwo, string enterAnimalThree, string enterFood, string enterAdjectiveThree, string enterEvent)
    {
        return _madLibService.EnterHere(enterNameOne, enterNameTwo, enterAdjectiveOne, enterAdjectiveTwo, enterAnimalOne, enterAnimalTwo, enterAnimalThree, enterFood, enterAdjectiveThree, enterEvent);
    }
}
