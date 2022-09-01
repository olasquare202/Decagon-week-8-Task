using Hotel.Core.Interface;
using Hotel_Rental.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Rental.Controllers
{
    public class LoginController : Controller
    {
        public readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            //if (user != null)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            //return View();

            if(ModelState.IsValid)
            {
               var userExist = _userService.Login(user.Email, user.Password).GetAwaiter().GetResult();
                if(userExist)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("error", "Invalid credentials");
                }
                return View();
            }
            else
            {
                ModelState.AddModelError("error", "Not registered");
            }
            return View();
        }

    }
}
