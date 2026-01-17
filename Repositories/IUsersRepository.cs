using AuthentificationFromYoutube.Models;
using System.Configuration;
namespace AuthentificationFromYoutube.Repositories
{
    public interface IUsersRepository
    {
        public void AddUser(Users c);
        public bool loginAction(Users c);
    }
}
