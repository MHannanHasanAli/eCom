using eCom.Database;
using eCom.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.Services
{
    public class ProductsServices
    {
        public List<product> GetProducts()
        {
            using (var context = new eComContext())
            {
                return context.products.ToList();
            }
        }

        public product Getproduct(int ID)
        {
            using (var context = new eComContext())
            {
                return context.products.Find(ID);
            }
        }
        public product Getproduct(string searchedName)
        {
            using (var context = new eComContext())
            {
                return context.products.Find(searchedName);
            }
        }

        public void Saveproduct(product product)
        {
            using(var context = new eComContext())
            {
                context.products.Add(product);

                context.SaveChanges();
            }
        }

        public void Updateproduct(product product)
        {
            using (var context = new eComContext())
            {
               context.products.Update(product);

                context.SaveChanges();
            }
        }

        public void Deleteproduct(product product)
        {
            using (var context = new eComContext())
            {
                context.products.Remove(product);

                context.SaveChanges();
            }
        }
    }
}
