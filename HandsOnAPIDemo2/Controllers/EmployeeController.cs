using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIDemo2.Repositories;
using HandsOnAPIDemo2.Models;

namespace HandsOnAPIDemo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeRepository repository = new EmployeeRepository();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(repository.GetAll());
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult Get(string id)
        {
            return Ok(repository.GetById(id));
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Employee data)
        {
            repository.Add(data);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Employee data)
        {
            repository.Update(data);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(string id)
        {
            repository.Delete(id);
            return Ok("Record Deleted");
        }
    }
}