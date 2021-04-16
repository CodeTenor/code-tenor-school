using CodeTenorSchool.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeTenorSchool.DataAccess.EntityMaps
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired(true);

            builder.Property(s => s.Surname)
                .IsRequired(true);

            builder.Property(s => s.Age)
                .IsRequired(true);

            builder.HasData(
                new Student("Jason", "Pietersen", 26),
                new Student("Sean", "Pietersen", 23),
                new Student("Claudia", "Pietersen", 50)
            );
        }
    }
}
