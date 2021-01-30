using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;
using System;
using System.Text;

namespace MyBlog.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.Email).IsRequired().HasMaxLength(50);
            builder.HasIndex(r => r.Email).IsUnique();
            builder.Property(u => u.Username).IsRequired().HasMaxLength(20);
            builder.HasIndex(u => u.Username).IsUnique();
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.Description).HasMaxLength(500);
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(30);
            builder.Property(u => u.Picture).IsRequired().HasMaxLength(250);
            builder.HasOne<Role>(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);

            builder.Property(u => u.CreatedByName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.ModifiedByName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.CreatedDate).IsRequired();
            builder.Property(u => u.ModifiedByName).IsRequired();
            builder.Property(u => u.IsActive).IsRequired();
            builder.Property(u => u.IsDeleted).IsRequired();
            builder.Property(u => u.Note).HasMaxLength(500);
            builder.ToTable("Users");

            builder.HasData(new User
            {
                Id = 1,
                RoleId = 1,
                FirstName = "Çağrı",
                LastName = "Sakaoğlu",
                Username = "cagrisakaoglu",
                Email = "cagrisakaoglu@gmail.com",
                PasswordHash = Encoding.ASCII.GetBytes("6e720cbd5606b8727478ea3042bb6734"),
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Description = "First admin user",
                Note = "Admin user that created at initial create process",
                Picture = "Picture: https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU"
            });
        }
    }
}