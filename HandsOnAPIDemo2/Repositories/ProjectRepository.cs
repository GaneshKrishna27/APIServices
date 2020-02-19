using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIDemo2.Models;

namespace HandsOnAPIDemo2.Repositories
{
    public class ProjectRepository
    {
        ProDBContext db = new ProDBContext();
        public List<Project> GetAll()
        {
             return db.Project.ToList();  
        }
        public void Add(Project data)
        {
            db.Project.Add(data);
            db.SaveChanges();
        }
        public void Update(Project data)
        {
            db.Project.Update(data);
            db.SaveChanges();
        }
        public void Delete(int Pid)
        {
            Project p = db.Project.Find(Pid);
            db.Project.Remove(p);
            db.SaveChanges();

        }


    }
}
