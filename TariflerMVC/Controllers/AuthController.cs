using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace TariflerMVC.Controllers
{
    public class AuthController : Controller
    {

        private IUserService _userService;
        private IAuthService _authService;

        public AuthController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserForRegisterDto register)
        {
            var result = _authService.Register(register);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
         
           
            return RedirectToAction("Info");
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserForLoginDto loginDto)
        {
            var loginResult = _authService.Login(loginDto);
            var find = _userService.Get(x => x.UserName == loginDto.UserName).Data;
            if (!loginResult.Success)
            {
                return BadRequest(loginResult.Message);
            }
            var token = _authService.CreateAccessToken(loginResult.Data);
            if (token.Success & ModelState.IsValid)
            {
          
                if (find.UserName=="Admin")
                {
                    return RedirectToAction("Index","Tarifs");
                }

                
            }
            return RedirectToAction("Tarifler", "YemekTarifler");
        }

        public IActionResult Info()
        {
            return View();
        }
    }
}
