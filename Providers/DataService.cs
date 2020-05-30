using MySqlReadersApp.Domain;

namespace MySqlReadersApp.Providers.Repositories
{
    public class DataService : IDataService
    {
        private readonly MySqlContext context;

        public DataService(MySqlContext context)
        {
            this.context = context;
        }

        public IUsersRepository UsersRepository => new UsersRepository(context);
        public IReadersRepository ReadersRepository => new ReadersRepository(context);
    }
}