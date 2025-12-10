using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Autod.Data
{
    public class AutoDbContext : DbContext
    {

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<CarService> CarServices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              @"Server=(localdb)\MSSQLLocalDB;Database=Autod;Trusted_Connection=True;");
        }

        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Указываем точность для decimal свойства Price
            modelBuilder.Entity<Service>()
                .Property(s => s.Price)
                .HasColumnType("decimal(18,2)");

            // Композитный ключ для CarService
            modelBuilder.Entity<CarService>()
                .HasKey(cs => new { cs.CarId, cs.ServiceId });

            // Связи CarService -> Car
            modelBuilder.Entity<CarService>()
                .HasOne(cs => cs.Car)
                .WithMany(c => c.CarServices)
                .HasForeignKey(cs => cs.CarId);

            // Связи CarService -> Service
            modelBuilder.Entity<CarService>()
                .HasOne(cs => cs.Service)
                .WithMany(s => s.CarServices)
                .HasForeignKey(cs => cs.ServiceId);

            // Schedule
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Car)
                .WithMany(c => c.Schedules)
                .HasForeignKey(s => s.CarId);

            // Ограничение — одна запись на одно и то же время
            modelBuilder.Entity<Schedule>()
                .HasIndex(s => s.StartTime)
                .IsUnique();
        }

    }
}