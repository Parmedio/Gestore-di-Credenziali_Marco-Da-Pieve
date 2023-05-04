using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credential_Manager.PasswordChecker
{
    internal interface IPWChecker
    {
        public bool IsValid();
        public string GetFailedRequirement();
    }
}
