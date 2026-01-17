using AuthentificationFromYoutube.Models;
using AuthentificationFromYoutube.ModelViews;
using Microsoft.AspNetCore.Mvc;
using AuthentificationFromYoutube.Mappers;
using AuthentificationFromYoutube.Services;
using AuthentificationFromYoutube.Repositories;

namespace AuthentificationFromYoutube.Controllers
{
    public class UserController : Controller
    {
        ISessionStorageService _sessionStorageService;
        IUsersRepository _userrepo;
        public UserController(ISessionStorageService _sessionStorageService, IUsersRepository _userrepo) 
        { 
            this._sessionStorageService = _sessionStorageService;
            this._userrepo = _userrepo;
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
                _userrepo.AddUser(u);
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
                if (_userrepo.loginAction(u)) 
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
