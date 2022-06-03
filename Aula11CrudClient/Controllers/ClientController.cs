using System.Collections;
using System.Collections.Generic;
using Aula11CrudClient.Models.Domains;
using Aula11CrudClient.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Aula11CrudClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private IClientRepository repository;
       
        public ClientController(IClientRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet()]
        public IEnumerable<Client>Get()
        {
            return repository.GetAll();
        }

        [HttpPost()]
        public IActionResult Post([FromBody]Client client)
        {
            repository.Create(client);
            return Ok(client);
        } 
    }
}