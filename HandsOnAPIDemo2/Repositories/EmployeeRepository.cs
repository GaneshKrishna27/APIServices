using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIDemo2.Models;

namespace HandsOnAPIDemo2.Repositories
{
    public class EmployeeRepository
    {
        //Get all employees
        public List<Employee> GetAll()
        {
            using (ProDBContext db = new ProDBContext())
            {
                return db.Employee.ToList();
            }
        }
        //Get Employee by id
        public Employee GetById(string Eid)
        {
            using (ProDBContext db = new ProDBContext())
            {
                return db.Employee.Find(Eid);
            }
        }
        //Add Employee
        public void Add(Employee data)
        {
            using (ProDBContext db = new ProDBContext())
            {
                db.Employee.Add(data);
                db.SaveChanges();

            }
        }
        //Delete Record
        public void Delete(string Eid)
        {
            using (ProDBContext db = new ProDBContext())
            {
                Employee e = db.Employee.Find(Eid);
                db.Employee.Remove(e);
                db.SaveChanges();
            }
        }
        public void Update(Employee data)
        {
            using (ProDBContext db=new ProDBContext())
            {
                db.Employee.Update(data);
                db.SaveChanges();
            }
        }
    }
}
