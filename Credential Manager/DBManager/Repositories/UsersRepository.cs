using DBManager.Models.Entities;
using DBManager.Repositories.DBContext;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager.Repositories
{
    public interface IUsersRepository
    {
        bool Insert(User user);
        void Query();
    }
    internal class UsersRepository : IUsersRepository
    {
        private readonly ILogger<UsersRepository> _logger;
        private readonly CredentialContext _db;

        public UsersRepository(CredentialContext context, ILogger<UsersRepository> logger)
        {
            _logger = logger;
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
            catch (Exception e)
            {
                _logger.LogError(e, "Can not insert new user");
                return false;
            }
        }

        public void Query()
        {
            throw new NotImplementedException();
        }
    }
}
