using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string UserName { get; set; }
        public int Password { get; set; }
        public string Role { get; set; }

        public BasicAuthenticationService()
        {
            
        }

        public BasicAuthenticationService(string UserName, int Password, string Role)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Role = Role;
        }

        public bool AuthenticateUser(string UserName, int Password)
        {
            if(this.UserName == UserName && this.Password == Password)
            {
                return true;
            }

            return false;
        }

        public bool AuthorizeUser(string UserName, string Role)
        {
            if (this.UserName == UserName && this.Role == Role)
            {
                return true;
            }

            return false;
        }
    }
}
