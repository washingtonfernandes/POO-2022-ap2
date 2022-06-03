using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula11CrudClient.Models.Domains;
using Aula11CrudClient.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Aula11CrudClient.Controllers
{
     [ApiController]
    [Route("[controller]")]
    public class DebitController : ControllerBase
    {
         private IDebitRepository repository;
       
        public DebitController(IDebitRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet()]
        public IEnumerable<Debit>Get()
        {
            return repository.GetAll();
        }

        [HttpPost()]
        public IActionResult Post([FromBody]Debit debit)
        {
            repository.Create(debit);
            return Ok(debit);
        } 
    }
    
}