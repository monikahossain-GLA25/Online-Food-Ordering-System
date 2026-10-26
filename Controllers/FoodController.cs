using Microsoft.AspNetCore.Mvc;

namespace Online_Food_Ordering_System.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
