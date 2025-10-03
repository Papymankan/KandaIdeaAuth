using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class AccountController : Controller
    {
        // Static list to simulate database
        private static List<User> _users = new List<User>();

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        //[HttpPost]
        //public IActionResult Login(string username, string password)
        //{
        //    var user = _users.FirstOrDefault(u => u.Username == username && u.Password == password);

        //    if (user != null)
        //    {
        //        // Store username in session
        //        HttpContext.Session.SetString("LoggedInUser", user.Username);
        //        return RedirectToAction("Profile");
        //    }

        //    ViewBag.Error = "Invalid username or password.";
        //    return View();
        //}

        //// GET: /Account/Register
        //[HttpGet]
        //public IActionResult Register()
        //{
        //    return View();
        //}

        //// POST: /Account/Register
        //[HttpPost]
        //public IActionResult Register(User newUser)
        //{
        //    if (_users.Any(u => u.Username == newUser.Username))
        //    {
        //        ViewBag.Error = "Username already exists!";
        //        return View();
        //    }

        //    _users.Add(newUser);
        //    HttpContext.Session.SetString("LoggedInUser", newUser.Username);

        //    return RedirectToAction("Profile");
        //}

        //// GET: /Account/Profile
        //public IActionResult Profile()
        //{
        //    var username = HttpContext.Session.GetString("LoggedInUser");
        //    if (string.IsNullOrEmpty(username))
        //    {
        //        return RedirectToAction("Login");
        //    }

        //    var user = _users.FirstOrDefault(u => u.Username == username);
        //    return View(user);
        //}

        //// GET: /Account/Logout
        //public IActionResult Logout()
        //{
        //    HttpContext.Session.Clear();
        //    return RedirectToAction("Login");
        //}
    }
}
