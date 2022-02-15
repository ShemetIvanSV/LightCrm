using System.Data.Entity;

namespace LightCrmData.Models
{
    public class PatientContext : DbContext
    {
        public PatientContext() : base("name=PatientDBConnectionString") { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Timetables> Timables { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
