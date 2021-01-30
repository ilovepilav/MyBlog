using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.Concrete;
using System;

namespace MyBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(120).IsRequired(true); // Required "true" default gelir.
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50).IsRequired();
            builder.Property(a => a.SeoDescription).HasMaxLength(150).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70).IsRequired();
            builder.Property(a => a.ViewCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50).IsRequired();
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500).IsRequired(false);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");

            builder.HasData(new Article
            {
                Id = 1,
                CategoryId = 1,
                Title = "Hello to C#",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                Thumbnail = "Default.jpg",
                SeoDescription = "C# article placeholder",
                SeoTags = "C#, C# 9",
                SeoAuthor = "Çağrı Sakaoğlu",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C# Blog Article Placeholder",
                UserId = 1,
                ViewCount = 666,
                CommentCount = 1
            });
        }
    }
}