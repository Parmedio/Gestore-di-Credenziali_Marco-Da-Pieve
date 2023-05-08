using DBManager.Repositories.DBContext;
using DBManager.Repositories;
using DBManager.Services;

namespace Credential_Manager.MailChecker
{
    internal class IsAlreadyInDB : MailChecker
    {
        public override (bool, string) ProcessRequest(string userEmail)
        {
            var context = new CredentialContext();
            var usersRepository = new UsersRepository(context);
            var usersService = new UsersService(usersRepository);

            if (!usersService.IsAreadyUserMail(userEmail))
            {
                if (_successor != null)
                    return _successor.ProcessRequest(userEmail);
                return (true, "Inserted email is NOT in databse and meet format requirements");
            }
            return (false, "- Inserted email is ALREADY in databse");
        }
    }
}
