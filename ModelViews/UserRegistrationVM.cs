using Microsoft.AspNetCore.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace AuthentificationFromYoutube.ModelViews
{
    public class UserRegistrationVM
    {
        [Required]
        public string login { get; set; }
        [Required]
        [MinLength(8,ErrorMessage = "Password must have more than 8 ch")]
        public string password { get; set; }
        [Required]
        public string nom {  get; set; }
        [Required]
        public string prenom { get; set; }


    }
}
