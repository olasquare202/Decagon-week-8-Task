
using Hotel.Core.Interface;
using Hotel_Rental.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Rental.Controllers
{
    public class SignUpController : Controller
    {
        public readonly IUserService _userService;
        public SignUpController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            //if (user != null)
            //{
            //    if (!Validation.CheckEmail(user.Email))
            //    {
            //        return View();
            //    }
            //    if (!Validation.CheckPassword(user.Password))
            //    {
            //        return View();
            //    }
            //    _userService.RegisterUser(user).GetAwaiter();
            //    return RedirectToAction("Index", "Login");
            //}
            //return View();

            if (ModelState.IsValid)
            {
                _userService.RegisterUser(user).GetAwaiter();
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ModelState.AddModelError("error", "Not registered");
            }
            return View();  
        }
    }
}
