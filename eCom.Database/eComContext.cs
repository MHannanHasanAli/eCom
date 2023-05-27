using eCom.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.Database
{
    public class eComContext : DbContext, IDisposable
    {
        public eComContext() { }
        public eComContext(DbContextOptions<eComContext> options) : base(options) { }

        public DbSet<category> categories { get; set; }
        public DbSet<product> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=eCom-Database;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }

    
}
