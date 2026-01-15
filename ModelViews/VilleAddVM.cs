using System.ComponentModel.DataAnnotations;

namespace AuthentificationFromYoutube.ModelViews
{
    public class VilleAddVM
    {
        [Required(ErrorMessage = "obligatoire !!!")]
        [MinLength(3,ErrorMessage = "minimum c'est 3 carac")]
        [MaxLength(20,ErrorMessage ="ne depasse pas 20 charac")]
        public string Libelle { get; set; }

    }
}
