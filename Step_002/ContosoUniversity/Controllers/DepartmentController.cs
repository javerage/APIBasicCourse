using Microsoft.AspNetCore.Mvc;

using ContosoUniversity.Domain.Entities;
using ContosoUniversity.Infrastructure.Repositories;

namespace ContosoUniversity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        protected CrudRepository<Department> _repository;

        public DepartmentController()
        {
            _repository = new CrudRepository<Department>();
        }

        [HttpGet]
        [Route("")]
        public IActionResult Get(){
            return Ok(_repository.GetAll());
        }
        
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id){
            return Ok(_repository.GetById(id));
        }

        [HttpGet]
        [Route("findBy")]
        public IActionResult Get([FromQuery]Department department){
            Func<Department, bool> filter = x => x.Name.Contains(department.Name);
            return Ok(_repository.FindBy(filter));
        }
    }
}