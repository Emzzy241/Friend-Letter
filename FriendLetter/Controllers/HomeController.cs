using FriendLetter.Models;
using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Letter()
    { 
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.Recipient = "Dynasty";
        myLetterVariable.Sender = "Ibrahim";
        return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string myLocation1, string myLocation2, string myLocation3, string mySouvenir1, string mySouvenir2, string mySouvenir3)
    {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.Recipient = recipient;
        myLetterVariable.Sender = sender;

        myLetterVariable.VacateLocation1 = myLocation1;
        myLetterVariable.VacateLocation2 = myLocation2;
        myLetterVariable.VacateLocation3 = myLocation3;

        myLetterVariable.ItemSouvenir1 = mySouvenir1;
        myLetterVariable.ItemSouvenir2 = mySouvenir2;
        myLetterVariable.ItemSouvenir3 = mySouvenir3;
        return View(myLetterVariable);
    }

  }
}