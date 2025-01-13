using HospitalManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.DAL.Contexts;

public class HospitalManagementDbContext : DbContext
{
    public HospitalManagementDbContext(DbContextOptions opt) : base(opt) { }

    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HospitalManagementDbContext).Assembly);
    }
}
