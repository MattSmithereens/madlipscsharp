using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
    public class HomeController : Controller

    {
        [Route("/")]
        public ActionResult Hello()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient("Lina");
            myLetterVariable.SetSender("John");
            return View(myLetterVariable);
        }
    }
}