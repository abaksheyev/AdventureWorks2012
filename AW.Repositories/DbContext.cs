using AW.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW.Repositories
{
    public class AWDataContext : DbContext
    {
        public DbSet<Currency> Currencies { get; set; }

        public AWDataContext()
            : base("name=DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new Currency.Configuration());
        }
    }
}
