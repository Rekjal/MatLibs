using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers {
  public class HomeController : Controller {

    [Route("/")]
    public ActionResult Home ()
    {
      // Answers answers = new Answers();
      // answers.input1 = 
      return View();
    }
    [Route("/madlib")]
    public ActionResult MadLib(string input1, string input2, string input3)
    {
      Answers answers = new Answers();
      answers.input1 = input1;
      answers.input2 = input2;
      answers.input3 = input3;
      return View(answers);
    }
  }
}
