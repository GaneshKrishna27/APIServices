using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderService.Models;

namespace OrderService.Repositories
{
    public interface IOrderRepository
    {
        List<Orders> GetAllItems();
        Orders GetById(string id);
        void AddItem(Orders obj);
        void DeleteItem(string id);
        void UpdateItem(Orders obj);
    }
}
