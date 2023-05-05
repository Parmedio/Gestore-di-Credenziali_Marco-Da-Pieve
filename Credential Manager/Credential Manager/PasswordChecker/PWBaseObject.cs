namespace Credential_Manager.PasswordChecker
{
    internal class PWBaseObject : IPWChecker
    {
        private string _password;

        public PWBaseObject(string password) => _password = password;

        public bool IsValid() => _password != string.Empty;
        public string GetFailedRequirement() => IsValid() ? string.Empty : "- Password is empty\n";
    }
}
