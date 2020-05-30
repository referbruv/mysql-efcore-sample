using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MySqlReadersApp.Domain;
using MySqlReadersApp.Domain.Entities;

namespace MySqlReadersApp.Providers.Repositories
{
    public class ReadersRepository : IReadersRepository
    {
        private readonly MySqlContext context;

        public ReadersRepository(MySqlContext context)
        {
            this.context = context;
        }

        public List<Reader> Get(Expression<Func<Reader, bool>> predicate)
        {
            return context.Readers.Include(x => x.User).Where(predicate).ToList();
        }

        public Reader Insert(Reader entity) 
        {
            this.context.Readers.Add(entity);
            this.context.SaveChanges();
            return entity;
        }
    }
}