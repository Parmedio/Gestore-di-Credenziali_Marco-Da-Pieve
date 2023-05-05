namespace Credential_Manager.PasswordChecker.Checkers_Decorator
{
    internal class AtLeastOneSpecialChar : PWChecker
    {
        public AtLeastOneSpecialChar(IPWChecker previousChecker, string password) : base(previousChecker, password)
        {
            FailMessage = "Password must be at least one special char";
        }


        protected override bool CurrentCheck() => Password.Any(x => !char.IsLetterOrDigit(x));
    }
}
