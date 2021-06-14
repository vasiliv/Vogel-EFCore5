using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore5WebApp.Core.Entities;

namespace EFCore5WebApp.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<LookUp> LookUps { get; set; }

        private async Task SaveDemo()
        {
            var context = new AppDbContext();
            await context.SaveChangesAsync();
        }
        public AppDbContext() : base()
        { }
        public AppDbContext(DbContextOptions options) : base(options)
        {
            var context = new AppDbContext(
            new DbContextOptionsBuilder<AppDbContext>().UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DemoDb; Trusted_Connection = True; MultipleActiveResultSets = true").Options);
        }
    }
}
