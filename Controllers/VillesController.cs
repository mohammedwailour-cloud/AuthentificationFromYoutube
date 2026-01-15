using AuthentificationFromYoutube.Mappers;
using AuthentificationFromYoutube.Models;
using AuthentificationFromYoutube.ModelViews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using AuthentificationFromYoutube.Filters;


namespace AuthentificationFromYoutube.Controllers
{
    [AuthFilter]
    public class VillesController : Controller
    {
        public IActionResult AddVille()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddVille(VilleAddVM vm)
        {
            if (ModelState.IsValid) 
            {
                Villes v = AddMapper.getvillefromVmToModel(vm);
                v.Add();
                return RedirectToAction("Index");
            }
          
            return View();
        }
        

    }
}
