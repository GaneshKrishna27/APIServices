using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        ProDBContext db = new ProDBContext();
        [HttpGet]
        public List<Project> GetAll()
        {
            return db.Project.ToList();
        }
        [HttpGet("{id}")]
        [Route("GetById/{id}")]
        public Project GetById(int id)
        {
            return db.Project.Find(id);
        }
        [HttpGet("{name}")]
        [Route("GetByName/{name}")]
        public Project GetByName(string name)
        {
            return db.Project.SingleOrDefault(p => p.ProjectName == name);
        }
        [HttpPost]
        [Route("Add")]
        public void Add(Project item)
        {
            db.Project.Add(item);
            db.SaveChanges();

        }
        [HttpPut]
        [Route("update/{id}")]
        public void Put(int id)
        {
            Project p = db.Project.Find(id);
            p.ProjectName= "gk";
            db.Project.Update(p);
            db.SaveChanges();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            Project p = db.Project.Find(id);
            db.Remove(p);
            db.SaveChanges();
        }
    }
}