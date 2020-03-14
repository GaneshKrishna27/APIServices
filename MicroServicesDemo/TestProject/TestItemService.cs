using ItemService.Models;
using ItemService.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    [TestFixture]
    public class TestItemService
    {
        ItemRepository _repo;
        [SetUp]
        public void SetUp()
        {
            _repo = new ItemRepository(new ItemService.Models.ShopDBContext());
        }
        [Test]
        public void TestGetAllItems()
        {
            var result = _repo.GetAllItems();
            Assert.NotNull(result);
            Assert.GreaterOrEqual(result.Count, 0);
        }
        [Test]
        public void TestGetById()
        {
            _repo.AddItem(new Items()
            {
                Itemid="i004",
                Name="gkkk",
                Price=1020,
                Stock=10
            });
            var result = _repo.GetById("4");
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestDeleteItem()
        {
            _repo.DeleteItem("i004");
            var result = _repo.GetById("i004");
            Assert.Null(result);
        }
        [Test]
        public void TestUpdate()
        {
            Items item = _repo.GetById("4");
            item.Price = 9955;
            _repo.UpdateItem(item);
        Items item1= _repo.GetById("4");
            Assert.AreSame(item1,item);
        }
            
    }
}
