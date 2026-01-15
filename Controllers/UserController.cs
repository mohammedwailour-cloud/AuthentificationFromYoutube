using AuthentificationFromYoutube.Models;
using AuthentificationFromYoutube.ModelViews;
using Microsoft.AspNetCore.Mvc;
using AuthentificationFromYoutube.Mappers;
using AuthentificationFromYoutube.Services;

namespace AuthentificationFromYoutube.Controllers
{
    public class UserController : Controller
    {
        ISessionStorageService _sessionStorageService;
        public UserController(ISessionStorageService _sessionStorageService) 
        { 
            this._sessionStorageService = _sessionStorageService;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserRegistrationVM vm)
        {
            if (ModelState.IsValid)
            {
                Users u = RegistrationMapper.GetUserfromRegistrationVm(vm); 
                u.AddUser();
            }
            return View();
        }

        public IActionResult Login() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginVM vm)
        {
            if (ModelState.IsValid)
            {
                Users u = RegistrationMapper.GetUserfromLoginVm(vm);
                if (u.loginAction()) 
                { 
                _sessionStorageService.SetToSession("Nom", u.nom, HttpContext );
                _sessionStorageService.SetToSession("Prenom", u.prenom, HttpContext);
                return RedirectToAction("AddVille", "Villes");
                }
            }
           
            return View();
        }

        public IActionResult Logout()
        {

            _sessionStorageService.Clear(HttpContext);
            return RedirectToAction(nameof(Login));
        }
    }
}
