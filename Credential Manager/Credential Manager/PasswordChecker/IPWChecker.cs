namespace Credential_Manager.PasswordChecker
{
    internal interface IPWChecker
    {
        public bool IsValid();
        public string GetFailedRequirement();
    }
}
