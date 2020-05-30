using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySqlReadersApp.Domain.Entities;
using MySqlReadersApp.Providers.Repositories;

namespace MySqlReadersApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReadersController : ControllerBase, IController<Reader>
    {
        private readonly IDataService data;
        public ReadersController(IDataService data)
        {
            this.data = data;
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<Reader> Get()
        {
            return this.data.ReadersRepository.Get(x => x.Id > 0);
        }

        [HttpPost]
        public Reader Post(Reader reader)
        {
            var res = this.data.ReadersRepository.Insert(reader);
            return res;
        }
    }
}