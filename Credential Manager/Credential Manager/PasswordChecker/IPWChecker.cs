namespace Credential_Manager.PasswordChecker
{
    public interface IPWChecker
    {
        public bool IsValid();
        public string GetFailedRequirement();
    }
}
