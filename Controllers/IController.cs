using System.Collections.Generic;

namespace MySqlReadersApp.Controllers
{
    public interface IController<T> where T : new()
    {
        IEnumerable<T> Get();
        T Post(T entity);
    }
}