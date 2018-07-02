using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
    public class HomeController : Controller

    {
        //[Route("/")]
        //public ActionResult Home()
        //{
        //    LetterVariable myLetterVariable = new LetterVariable();
        //    return View(myLetterVariable);
        //}

        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/formLib")]
        public ActionResult GreetingCard()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetName(Request.Query["Name"]);
            myLetterVariable.SetAnotherName(Request.Query["AnotherName"]);
            myLetterVariable.SetAnimal(Request.Query["Animal"]);
            myLetterVariable.SetExclamation(Request.Query["Exclamation"]);
            myLetterVariable.SetVerb(Request.Query["Verb"]);
            myLetterVariable.SetNoun(Request.Query["Noun"]);
            return View("Home", myLetterVariable);
        }
    }
}