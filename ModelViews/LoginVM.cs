using System.ComponentModel.DataAnnotations;

namespace AuthentificationFromYoutube.ModelViews
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Login est obligatoire" )]
        public string login {  get; set; }
        [Required(ErrorMessage = "Mot de passe est obligatoire")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
