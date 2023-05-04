using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credential_Manager.PasswordChecker.Checkers_Decorator
{
    internal class MinLength : PWChecker
    {
        public MinLength(IPWChecker previousChecker, string password) : base(previousChecker, password)
        {
            FailMessage = "Password must be at least 7 characters";
        }

        protected override bool CurrentCheck() => Password.Length >= 7;
    }
}
