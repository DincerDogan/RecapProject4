using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //Db tabloları ile proje klaslarını bağlamak
    public class MyDatabaseContext : DbContext //kurulan entityframeworkte DbContext var.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //projem hangi veritabanıyla ilişkili
        {
         // optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentACar;Trusted_Connection=true"); //@ sembolu \ icin IP ve sifre veya local db hangi veritabanına bağlanacağımızı söylüyoruz
           optionsBuilder.UseSqlServer(@"Data Source=IC-HW-NB328\SQLEXPRESS;Database=RentACar11;Trusted_Connection=true"); //@ sembolu \ icin IP ve sifre veya local db hangi veritabanına bağlanacağımızı söylüyoruz

        }
        //hangi veritabanına bağlanacağımızı söylüyoruz
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }

      
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        public DbSet<CarImage> CarImages { get; set; }
    }
}
