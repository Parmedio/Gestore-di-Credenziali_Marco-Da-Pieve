using DBManager.Models.Entities;
using DBManager.Repositories;

namespace DBManager.Services
{
    public interface IUsersService
    {
        int Insert(string username, string password);
        bool IsAreadyUserMail(string username);
        User SearchByIDAndPassword(int userID, string password);
    }
    public class UsersService : IUsersService
    {
        private IUsersRepository _usersRepository;

        public UsersService(IUsersRepository userRepository)
        {
            _usersRepository = userRepository;
        }
        public int Insert(string mail, string password)
        {
            var userToInsert = new User()
            {
                UserEmail = mail,
                Password = password,
                RegistrationDate = DateTime.Now.ToString("yyyyMMdd")
            };

            try
            {
                _usersRepository.Insert(userToInsert);
                return _usersRepository.SearchByMailAndPassword(mail, password);
            }
            catch (Exception e)
            {
                throw new Exception("Somthing went wrong when inserting new user", e);
            }
        }

        public bool IsAreadyUserMail(string mail) => _usersRepository.IsAreadyUserMail(mail);

        public User SearchByIDAndPassword(int userID, string password) => _usersRepository.SearchByIDAndPassword(userID, password);
    }
}
