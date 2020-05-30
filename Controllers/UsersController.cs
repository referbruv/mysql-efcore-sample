using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySqlReadersApp.Domain.Entities;
using MySqlReadersApp.Providers.Repositories;

namespace MySqlReadersApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase, IController<User>
    {
        private readonly IDataService data;
        public UsersController(IDataService data)
        {
            this.data = data;
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<User> Get()
        {
            return this.data.UsersRepository.Get(x => x.IsActive == true);
        }

        [HttpPost]
        public User Post(User user)
        {
            var res = this.data.UsersRepository.Insert(user);
            return res;
        }
    }
}