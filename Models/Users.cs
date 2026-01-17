using Microsoft.Data.SqlClient;
namespace AuthentificationFromYoutube.Models
{
    public class Users
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }


    }
}
