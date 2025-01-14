using ClientMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClientMVC.Conficuration
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(d => d.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(d => d.Surname)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
