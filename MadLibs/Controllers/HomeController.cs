using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult TheGoofyAdventure()
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();

      myMadLibsVariable.Name = "Richard";
      myMadLibsVariable.Noun1 = "rock";
      myMadLibsVariable.Noun2 = "stick";
      myMadLibsVariable.Verb = "fly";
      myMadLibsVariable.Adjective = "righteous";
      myMadLibsVariable.FoodItem = "General Tso's Chicken";

      return View(myMadLibsVariable);

    }
    [Route("/form")]
    public ActionResult Form() { return View(); }
    [Route("/result")]
    public ActionResult Result(string name, string noun1, string noun2, string verb, string adjective, string fooditem)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.Name = name;
      myMadLibsVariable.Noun1 = noun1;
      myMadLibsVariable.Noun2 = noun2;
      myMadLibsVariable.Verb = verb;
      myMadLibsVariable.Adjective = adjective;
      myMadLibsVariable.FoodItem = fooditem;
      return View(myMadLibsVariable);
    }
  }


}