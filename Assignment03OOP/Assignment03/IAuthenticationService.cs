using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string UserName, int Password);

        public bool AuthorizeUser(string UserName, string Role);
    }
}
