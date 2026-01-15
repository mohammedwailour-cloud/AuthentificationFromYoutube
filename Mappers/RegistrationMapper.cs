using AuthentificationFromYoutube.Models;
using AuthentificationFromYoutube.ModelViews;

namespace AuthentificationFromYoutube.Mappers
{
    public class RegistrationMapper
    {
        public static Users GetUserfromRegistrationVm(UserRegistrationVM vm)
        {
            return new Users
            {
                login = vm.login,
                password = vm.password,
                nom = vm.nom,
                prenom = vm.prenom,
            };

        }

        public static Users GetUserfromLoginVm(LoginVM vm)
        {
            return new Users
            {
                login = vm.login,
                password = vm.password,
            };
        }
    }
}
