using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credential_Manager.PasswordChecker.Checkers_Decorator
{
    internal class AtLeastOneCapitalChar : PWChecker
    {
        public AtLeastOneCapitalChar(IPWChecker previousChecker, string password) : base(previousChecker, password)
        {
            FailMessage = "Password must contain at least one capital letter";
        }

        protected override bool CurrentCheck() => Password.Any(char.IsUpper);
    }
}
