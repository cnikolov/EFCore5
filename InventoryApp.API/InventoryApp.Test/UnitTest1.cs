using System.ComponentModel.Design.Serialization;
using System.Linq;
using InventoryApp.Data;
using InventoryApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InventoryApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetProducts()
        {
            var context = new InventoryAppContext();
            context.Database.EnsureCreated();
            var products = context.Products.ToList();
        }
        [TestMethod]
        public void AddProduct()
        {
            var context = new InventoryAppContext();
            context.Database.EnsureCreated();
            context.Products.Add(new Product() {Title = "Selfie Stick", Description = "Up to 1.5 M", Price = 3.40});
            context.SaveChanges();
        }
    }
}
