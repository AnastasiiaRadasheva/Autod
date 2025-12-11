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

            // CarService — история выполненных услуг
            // Рекомендация: использовать отдельный Id как PK, если одна услуга может выполняться несколько раз
            modelBuilder.Entity<CarService>()
                .HasKey(cs => new { cs.CarId, cs.ServiceId, cs.DateOfService }); // альтернатива: можно добавить Id

            modelBuilder.Entity<CarService>()
                .HasOne(cs => cs.Car)
                .WithMany(c => c.CarServices)
                .HasForeignKey(cs => cs.CarId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CarService>()
                .HasOne(cs => cs.Service)
                .WithMany(s => s.CarServices)
                .HasForeignKey(cs => cs.ServiceId)
                .OnDelete(DeleteBehavior.Cascade);

            // Schedule — планирование записи автомобиля на обслуживание
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Car)
                .WithMany(c => c.Schedules)
                .HasForeignKey(s => s.CarId)
                .OnDelete(DeleteBehavior.Cascade);

            // Опционально — связь Schedule -> Service, если хотим знать услугу заранее
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Service)
                .WithMany()
                .HasForeignKey(s => s.ServiceId)
                .OnDelete(DeleteBehavior.Restrict); // не удаляем услугу, если есть расписания

            // Индекс для предотвращения пересечения записей
            // Проверка уникальности StartTime для конкретной машины
            modelBuilder.Entity<Schedule>()
                .HasIndex(s => new { s.CarId, s.StartTime })
                .IsUnique();

            // Schedule -> Worker
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Worker)
                .WithMany(w => w.Schedules)
                .HasForeignKey(s => s.WorkerId)
                .OnDelete(DeleteBehavior.Restrict); 

        }

    }
}