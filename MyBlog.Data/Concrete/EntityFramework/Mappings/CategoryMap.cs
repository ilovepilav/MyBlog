using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;
using System;

namespace MyBlog.Data.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).HasMaxLength(70).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(500).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500).IsRequired(false);
            builder.ToTable("Categories");

            builder.HasData(new Category
            {
                Id = 1,
                Name = "C#",
                Description = "C# Category",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# Blog Category"
            });
        }
    }
}