using NETfacilitiesDsi.Security;

namespace NETfacilitiesDsi.Request
{
    public class LoginRequest
    {
        public bool Login(string email, string password)
        {
            AuthSecurity authSecurity = new AuthSecurity();
            return authSecurity.LoginSecurity(email, password);
        }
    }
}