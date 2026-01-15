namespace AuthentificationFromYoutube.Services
{
    public class SessionStorageService : ISessionStorageService
    {
        public void SetToSession(string key, string value, HttpContext context)
        {
            context.Session.SetString(key, value);
        }
        public void Clear(HttpContext context)
        {
            context.Session.Clear();
        }
    }
}
