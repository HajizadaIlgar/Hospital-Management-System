using HospitalManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagement.DAL.Configurations;

internal class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.HasKey(d => d.Id);

        builder.Property(d => d.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(d => d.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(d => d.DOB)
            .IsRequired();

        builder.Property(d => d.PhoneNumber)
            .IsRequired()
            .HasMaxLength(15);

        builder.Property(d => d.Email)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(d => d.Specialization)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(d => d.LicenseNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(d => d.RegistrationNumber)
            .HasMaxLength(50);

        builder.Property(d => d.OfficeAddress)
            .HasMaxLength(300);

        builder.HasMany(d => d.Patients)
            .WithOne(p => p.Doctor)
            .HasForeignKey(p => p.DoctorId);

        builder.Property(d => d.CreatedAt)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired();

        builder.Property(d => d.UpdateAt)
            .HasDefaultValueSql("GETDATE()")
            .IsRequired();
    }
}
