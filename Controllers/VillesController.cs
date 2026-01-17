using AuthentificationFromYoutube.Mappers;
using AuthentificationFromYoutube.Models;
using AuthentificationFromYoutube.ModelViews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using AuthentificationFromYoutube.Filters;
using AuthentificationFromYoutube.Repositories;


namespace AuthentificationFromYoutube.Controllers
{
    [AuthFilter]
    public class VillesController : Controller
    {
        IVillesRepository _villesrepo;
        public VillesController(IVillesRepository _villesrepo) 
        {
           this._villesrepo = _villesrepo;

        }
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
                _villesrepo.Add(v);
                return RedirectToAction("Index");
            }
          
            return View();
        }
        

    }
}
