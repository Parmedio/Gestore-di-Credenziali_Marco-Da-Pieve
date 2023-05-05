using DBManager.Models.Entities;
using DBManager.Repositories;
using Microsoft.Extensions.Logging;

namespace DBManager.Services
{
    public interface IUsersService
    {
        void Insert(string username, string password);
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
        public void Insert(string username, string password)
        {
            var userToInsert = new User()
            {
                UserName = username,
                Password = password,
                RegistrationDate = DateTime.Now.ToString("yyyyMMdd")
            };

            _usersRepository.Insert(userToInsert);
        }

        public bool IsAreadyUsername(string username)
        {
            return _usersRepository.IsAreadyUsername(username);
        }

        public User SearchByIDAndPassword(int userID, string password) => _usersRepository.SearchByIDAndPassword(userID, password);
    }
}
