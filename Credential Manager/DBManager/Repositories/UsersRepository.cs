using DBManager.Models.Entities;
using DBManager.Repositories.DBContext;
using Microsoft.Extensions.Logging;

namespace DBManager.Repositories
{
    public interface IUsersRepository
    {
        bool Insert(User user);
        bool IsAreadyUsername(string username);
        User SearchByIDAndPassword(int ID, string password);
    }
    public class UsersRepository : IUsersRepository
    {
        private readonly CredentialContext _db;

        public UsersRepository(CredentialContext context)
        {
            _db = context;
        }
        public bool Insert(User user)
        {
            try
            {
                _db.Users.Add(user);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool IsAreadyUsername(string username)
        {
            try
            {
                return _db.Users.Any(u => u.UserName == username);
            }
            catch
            {
                return false;
            }
        }

        public User SearchByIDAndPassword(int ID, string password)
        {
            try
            {
                return _db.Users.FirstOrDefault(u => u.UserId == ID && u.Password == password);
                
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
