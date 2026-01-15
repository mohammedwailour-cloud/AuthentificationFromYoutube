namespace AuthentificationFromYoutube.Services
{
    public interface ISessionStorageService
    {
        public void SetToSession(string key, string value, HttpContext context);
        public void Clear(HttpContext context);

    }
}
