using Document_Saver.Data;
using Document_Saver.Models;
using Microsoft.AspNetCore.Mvc;

namespace Document_Saver.Controllers
{
    public class UserController : Controller
    {
        private readonly DocumentDetailsContext _DB;
        public UserController(DocumentDetailsContext DB)
        {
            _DB = DB;
        }
        public IActionResult Index()
        {
            IEnumerable<User> objuserList = _DB.UserDetails;
            return View(objuserList);
        }

        public IActionResult Create()
        {
            return View();
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User obj)
        {
            if (ModelState.IsValid)
            {
                _DB.UserDetails.Add(obj);
                _DB.SaveChanges();
                TempData["success"] = "Data Created Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User obj)
        {
            var ele = _DB.UserDetails.Where(x => x.User_Name == obj.User_Name && x.User_Password == obj.User_Password).Count();
            if (ele>0)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View();
            }
            return View();

        }
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
