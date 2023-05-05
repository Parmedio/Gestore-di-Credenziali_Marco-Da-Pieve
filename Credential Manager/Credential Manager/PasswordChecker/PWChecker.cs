namespace Credential_Manager.PasswordChecker
{
    internal abstract class PWChecker : IPWChecker
    {
        private readonly IPWChecker _previousChecker;
        protected readonly string Password;
        protected string FailMessage;


        public PWChecker(IPWChecker previousChecker, string password)
        {
            _previousChecker = previousChecker;
            Password = password;
        }
        public bool IsValid() => _previousChecker.IsValid() && CurrentCheck();
        public string GetFailedRequirement() =>
            CurrentCheck() ?
            $"{_previousChecker.GetFailedRequirement()}" :
            $"{_previousChecker.GetFailedRequirement()}{FailMessage}";

        protected abstract bool CurrentCheck();

    }
}
