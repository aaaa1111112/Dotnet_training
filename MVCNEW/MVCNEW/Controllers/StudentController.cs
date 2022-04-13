using Microsoft.AspNetCore.Mvc;

namespace MVCNEW.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
