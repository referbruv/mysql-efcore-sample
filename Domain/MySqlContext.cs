using Microsoft.EntityFrameworkCore;
using MySqlReadersApp.Domain.Entities;

namespace MySqlReadersApp.Domain
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}