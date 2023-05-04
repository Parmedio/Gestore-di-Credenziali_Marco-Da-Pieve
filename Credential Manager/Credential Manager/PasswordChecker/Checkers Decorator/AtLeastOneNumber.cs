using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credential_Manager.PasswordChecker.Checkers_Decorator
{
    internal class AtLeastOneNumber : PWChecker
    {
        public AtLeastOneNumber(IPWChecker previousChecker, string password) : base(previousChecker, password)
        {
            FailMessage = "Password must contain al least one number.";
        }

        protected override bool CurrentCheck() => Password.Count(char.IsNumber) >= 1;
    }
}
