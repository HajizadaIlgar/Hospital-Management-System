using HospitalManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.DAL.Contexts
{
    public class HospitalManagementDbContext : DbContext
    {
        public HospitalManagementDbContext(DbContextOptions opt) : base(opt) { }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<Patient> Patients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //    modelBuilder.Entity<Patient>()
            //        .HasOne(x => x.Insurance)
            //        .WithMany(x => x.Patients)
            //        .HasForeignKey(x => x.InsuranceId);
            //    modelBuilder.Entity<Patient>()
            //        .HasOne(x => x.Doctor)
            //        .WithMany(x => x.Patients)
            //        .HasForeignKey(x => x.DoctorId);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HospitalManagementDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
