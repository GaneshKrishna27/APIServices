using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerDBContext db = new CustomerDBContext();
        // GET: api/Customer
        [HttpGet]
        public List<Customer> GetAll()
        {
            return db.Customer.ToList();
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        [Route("GetCustomerById/{id}")]
        public Customer GetCustomerById(int id)
        {
            return db.Customer.Find(id);
        }
        [HttpGet("{name}")]
        [Route("GetCustomerByName/{name}")]
        public Customer GetCustomerByName(string name)
        {
            return db.Customer.SingleOrDefault(p => p.Cname == name);
        }
        [HttpGet("{city}")]
        [Route("GetCustomerByCity/{city}")]
        public List<Customer> GetCustomerByCity(string city)
        {
            return db.Customer.Where(p => p.City == city).ToList();
        }

        // POST: api/Customer
        [HttpPost]
        [Route("Add")]
        public void Add(Customer data)
        {
            db.Customer.Add(data);
            db.SaveChanges();

        }

        // PUT: api/Customer/5
        [HttpPut]
        [Route("update/{id}")]
        public void Put(int id)
        {
            Customer p = db.Customer.Find(id);
            
            db.Customer.Update(p);
            db.SaveChanges();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Customer p = db.Customer.Find(id);
            db.Customer.Remove(p);
            db.SaveChanges();
        }
    }
}
