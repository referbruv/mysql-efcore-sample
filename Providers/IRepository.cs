using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using MySqlReadersApp.Domain.Entities;

namespace MySqlReadersApp.Providers.Repositories
{
    public interface IRepository<T> where T : new()
    {
        List<T> Get(Expression<Func<T, bool>> predicate);

        T Insert(T entity);
    }

    public interface IUsersRepository : IRepository<User> {}
    public interface IReadersRepository : IRepository<Reader> {}
}