using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseEntities.Models;

namespace DataBaseEntities.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            


            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Name= "Maryam", PhoneNumber = 1111111111, City = "Stockholm" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 2, Name = "Pontus", PhoneNumber = 222222222, City = "Paris" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = 3, Name = "Homa", PhoneNumber = 333333333, City = "Isfahan" });

            
        }
    }
}
