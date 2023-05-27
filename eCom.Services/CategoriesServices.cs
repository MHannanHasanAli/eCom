using eCom.Database;
using eCom.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.Services
{
    public class CategoriesServices
    {
        public List<category> GetCategories()
        {
            using (var context = new eComContext())
            {
                return context.categories.ToList();
            }
        }

        public category GetCategory(int ID)
        {
            using (var context = new eComContext())
            {
                return context.categories.Find(ID);
            }
        }

        public void SaveCategory(category category)
        {
            using(var context = new eComContext())
            {
                context.categories.Add(category);

                context.SaveChanges();
            }
        }

        public void UpdateCategory(category category)
        {
            using (var context = new eComContext())
            {
               context.categories.Update(category);

                context.SaveChanges();
            }
        }

        public void DeleteCategory(category category)
        {
            using (var context = new eComContext())
            {
                context.categories.Remove(category);

                context.SaveChanges();
            }
        }
    }
}
