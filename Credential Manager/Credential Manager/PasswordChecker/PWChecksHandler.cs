using Credential_Manager.PasswordChecker.Checkers_Decorator;

namespace Credential_Manager.PasswordChecker
{
    internal static class PWChecksHandler
    {
        public static (bool, string) GetReport(string password)
        {
            IPWChecker PWChecker = Analyze(password);
            return (PWChecker.IsValid(), PWChecker.GetFailedRequirement());
        }
        private static IPWChecker Analyze(string password)
        {
            IPWChecker passwordValidator = new PWBaseObject(password);
            passwordValidator = new MinLength(passwordValidator, password);
            passwordValidator = new AtLeastOneCapitalChar(passwordValidator, password);
            passwordValidator = new AtLeastOneNumber(passwordValidator, password);
            passwordValidator = new AtLeastOneSpecialChar(passwordValidator, password);
            return passwordValidator;
        }
    }
}
