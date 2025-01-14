using ClientMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClientMVC.Conficuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(d => d.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasIndex(d => d.Name)
                   .IsUnique();
        }
    }
}
