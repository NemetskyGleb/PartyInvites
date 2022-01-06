using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }
        // атрибут указывает MVC, что метод должен использоваться только для GET запросов
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        // атрибут указывает MVC, что метод должен использоваться только для POST запросов
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
    }
}