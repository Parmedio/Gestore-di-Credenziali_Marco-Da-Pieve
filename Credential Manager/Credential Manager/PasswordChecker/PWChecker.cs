using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credential_Manager.PasswordChecker
{
    internal abstract class PWChecker : IPWChecker
    {
        protected readonly IPWChecker _previousChecker;
        protected readonly string _password;
        protected string _failMessage;


        public PWChecker(IPWChecker previousChecker, string password)
        {
            _previousChecker = previousChecker;
            _password = password;
        }
        public bool IsValid() => _previousChecker.IsValid() && CurrentCheck();
        public string GetFailedRequirement() =>
            CurrentCheck() ?
            $"{_previousChecker.GetFailedRequirement()}" :
            $"{_previousChecker.GetFailedRequirement()}{_failMessage}";

        protected abstract bool CurrentCheck();

    }
}
