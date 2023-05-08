using System.Net.Mail;

namespace Credential_Manager.MailChecker
{
    internal class IsMail : MailChecker
    {
        public override (bool, string) ProcessRequest(string userEmail)
        {
            if (IsValidMail(userEmail))
            {
                if (_successor != null)
                    return _successor.ProcessRequest(userEmail);
                return (true, "Inserted string is a valid mail");
            }
            return (false, "- Inserted string is NOT a valid mail");
        }
        private bool IsValidMail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
