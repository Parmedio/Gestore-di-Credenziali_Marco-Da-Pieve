using Credential_Manager.PasswordChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credential_Manager.MailChecker
{
    internal abstract class MailChecker
    {
        protected MailChecker _successor;
        public void SetSuccessor(MailChecker successor)
        {
            _successor = successor;
        }
        public abstract (bool, string) ProcessRequest(string userEmail);
    }
}
