using DbEntityL1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbEntityL1
{
    public class EntityDbContext:DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Book> books { get; set; }
        public const string ConnectionString = "Server=(LocalDb)\\MSSQLLocalDB;Database=EntityDb;Trusted_Connection=True";
       // override OnConfigrtion than press tab=> 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
