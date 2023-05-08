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
