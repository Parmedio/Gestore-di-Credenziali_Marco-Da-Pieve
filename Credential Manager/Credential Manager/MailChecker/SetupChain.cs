using Credential_Manager.PasswordChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credential_Manager.MailChecker
{
    internal class SetupChain
    {
        private readonly MailChecker _chain;
        public SetupChain()
        {
            var check01 = new IsMail();
            var check02 = new IsAlreadyInDB();

            check01.SetSuccessor(check02);
            _chain = check01;
        }
        public MailChecker GetChain => _chain;
    }
}
