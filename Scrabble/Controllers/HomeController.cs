using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;

namespace Scrabble.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("Index");
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      ScrabbleScore model = new ScrabbleScore(Request.Form["word"]);
      model.AddScore();
      return View("Result", model);
    }
  }
}
