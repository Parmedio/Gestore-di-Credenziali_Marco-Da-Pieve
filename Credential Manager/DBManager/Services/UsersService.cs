using DBManager.Models.Entities;
using DBManager.Repositories;

namespace DBManager.Services
{
    public interface IUsersService
    {
        int Insert(string username, string password);
        bool IsAreadyUsername(string username);
        User SearchByIDAndPassword(int userID, string password);
    }
    public class UsersService : IUsersService
    {
        private IUsersRepository _usersRepository;

        public UsersService(IUsersRepository userRepository)
        {
            _usersRepository = userRepository;
        }
        public int Insert(string username, string password)
        {
            var userToInsert = new User()
            {
                UserName = username,
                Password = password,
                RegistrationDate = DateTime.Now.ToString("yyyyMMdd")
            };

            _usersRepository.Insert(userToInsert);
            return _usersRepository.SearchByMailAndPassword(username, password);
        }

        public bool IsAreadyUsername(string username) => _usersRepository.IsAreadyUsername(username);

        public User SearchByIDAndPassword(int userID, string password) => _usersRepository.SearchByIDAndPassword(userID, password);
    }
}
