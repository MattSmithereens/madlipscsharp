using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
    public class HomeController : Controller

    {
        [Route("/")]
        public ActionResult Home()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetName("Lina");
            myLetterVariable.SetAnotherName("John");
            myLetterVariable.SetAnimal("Lina");
            myLetterVariable.SetExclamation("John");
            myLetterVariable.SetVerb("Lina");
            myLetterVariable.SetNoun("John");
            return View(myLetterVariable);
        }
    }
}