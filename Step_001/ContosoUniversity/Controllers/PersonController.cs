using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContosoUniversity.Domain.Entities;
using ContosoUniversity.Infrastructure.Repositories;

namespace ContosoUniversity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private PersonRepository _repository;

        public PersonController()
        {
            _repository = new PersonRepository();
        }

        [HttpGet]
        [Route("")]
        public IActionResult Get(){
            return Ok(_repository.Get());
        }
        
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id){
            return Ok(_repository.Get(id));
        }

        [HttpGet]
        [Route("findBy")]
        public IActionResult Get([FromQuery]Person person){
            return Ok(_repository.Get(person));
        }
    }
}