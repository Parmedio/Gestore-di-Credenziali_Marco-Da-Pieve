using DBManager.Models.Entities;
using DBManager.Repositories.DBContext;

namespace DBManager.Repositories
{
    public interface IUsersRepository
    {
        bool Insert(User user);
        bool IsAreadyUsername(string username);
        User SearchByIDAndPassword(int ID, string password);
        int SearchByMailAndPassword(string mail, string password);
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

        public bool IsAreadyUsername(string username) => _db.Users.Any(u => u.UserName == username);

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

        public int SearchByMailAndPassword(string mail, string password)
        {
            try
            {
                var user =  _db.Users.FirstOrDefault(u => u.UserName == mail && u.Password == password);
                return user.UserId;
            }
            catch (Exception e)
            {
                throw new Exception("User not found", e);
            }
        }
    }
}
