using homework_37.Models;
using Microsoft.AspNetCore.Mvc;

namespace homework_37.Controllers
{
    public class ApiController : Controller
    {

        private readonly MyDBContext _context;
        public ApiController(MyDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CheckAccount()
        {
            return Content("");
        }

        public IActionResult Cities()
        {
            var cities = _context.Addresses.Select(c => c.City).Distinct();
            return Json(cities);
        }
    }
}
