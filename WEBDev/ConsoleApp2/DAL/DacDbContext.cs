using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp2.DAL
{
    internal class DacDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            //builder.AddJsonFile("appsettings.json");
            builder.AddJsonFile("appsettings.json");
            IConfiguration configuration = builder.Build();
            string ConnectionString = configuration.GetConnectionString("con");
           
            optionsBuilder.UseSqlServer(ConnectionString);
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
