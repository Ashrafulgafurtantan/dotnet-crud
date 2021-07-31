using System;
using System.Collections.Generic;
using System.Text;
using dotnet_crud.Models;
using Microsoft.EntityFrameworkCore;

namespace pos_system.Model
{
    public class DatabaseContext : DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-SEJCFC3;Database=DOTNETCRUD;Trusted_Connection=true";
      
        public DbSet<Student> Students { get; set; }
     /*   protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.User>().HasData(
                new User
                {
                    username = "admin",
                    password = "admin",
                    role = "ADMIN",
                }
            );
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
