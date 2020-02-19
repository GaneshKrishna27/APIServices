using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIDemo2.Models;
using HandsOnAPIDemo2.Repositories;

namespace HandsOnAPIDemo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        ProjectRepository repository = new ProjectRepository();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(repository.GetAll());
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Project data)
        {
            repository.Add(data);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Project data)
        {
            repository.Update(data);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok("deleted");
        }
       

    }
}