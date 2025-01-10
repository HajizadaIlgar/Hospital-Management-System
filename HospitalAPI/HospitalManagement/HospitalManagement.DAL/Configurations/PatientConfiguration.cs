using HospitalManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagement.DAL.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Surname)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.DOB)
                .IsRequired();

            builder.Property(p => p.PhoneNumber)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(p => p.SeriaNumber)
                .HasMaxLength(50);

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(p => p.RegistrationAddress)
                .HasMaxLength(300);

            builder.Property(p => p.CurrentAddress)
                .HasMaxLength(300);

            builder.Property(p => p.Gender)
                .IsRequired();

            builder.Property(p => p.BloodGroup)
                .IsRequired();


            builder.HasOne(p => p.Insurance)
                .WithMany(p => p.Patients)
                .HasForeignKey(p => p.InsuranceId);

            builder.Property(p => p.CreatedAt)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            builder.Property(p => p.UpdateAt)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();
        }
    }
}
