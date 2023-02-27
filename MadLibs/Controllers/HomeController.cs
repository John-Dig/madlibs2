using Microsoft.AspNetCore.Mvc;
// using FriendLetter.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello Muffin!"; }
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye you silly Muffin!!!"; }
  
  }


}