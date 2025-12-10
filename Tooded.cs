using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autod
{
    internal class Tooded
    {
    }
    public class Owner
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        public ICollection<CarService> CarServices { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public ICollection<CarService> CarServices { get; set; }
    }
    public class CarService
    {
        public int CarId { get; set; }
        public Car Car { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public DateTime DateOfService { get; set; }
        public int Mileage { get; set; }
    }
    public class Schedule
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
    }

}