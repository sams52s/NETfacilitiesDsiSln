namespace NETfacilitiesDsi.Security
{
    public class AuthSecurity
    {
        public bool LoginSecurity(string email, string password)
        {
            return !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) && (Equals(email, "abc") || Equals(password, "123"));
           // return !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) && (Equals(email, "adminx@dispostable.com") || Equals(password, "eys@YH3782kdkso3"));
        }
    }
}