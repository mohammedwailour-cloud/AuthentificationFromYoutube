using AuthentificationFromYoutube.Models;
using AuthentificationFromYoutube.ModelViews;
using System.Reflection.Metadata.Ecma335;

namespace AuthentificationFromYoutube.Mappers
{
    public class AddMapper
    {
        public static Villes getvillefromVmToModel(VilleAddVM vm) 
        {
            return new Villes { Libelle = vm.Libelle };
        }
       
    }
}
