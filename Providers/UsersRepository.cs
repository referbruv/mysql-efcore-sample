using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MySqlReadersApp.Domain;
using MySqlReadersApp.Domain.Entities;

namespace MySqlReadersApp.Providers.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly MySqlContext context;

        public UsersRepository(MySqlContext context)
        {
            this.context = context;
        }

        public List<User> Get(Expression<Func<User, bool>> predicate)
        {
            return this.context.Users.Where(predicate).ToList();
        }

        public User Insert(User entity) 
        {
            this.context.Users.Add(entity);
            this.context.SaveChanges();
            return entity;
        }
    }
}