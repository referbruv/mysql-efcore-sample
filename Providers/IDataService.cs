namespace MySqlReadersApp.Providers.Repositories
{
    public interface IDataService 
    {
        IUsersRepository UsersRepository { get; }
        IReadersRepository ReadersRepository { get; }
    }
}