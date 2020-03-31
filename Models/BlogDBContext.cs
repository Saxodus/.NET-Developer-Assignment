using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreServices.Models
{
    public partial class BlogDBContext : DbContext
    {
        public BlogDBContext()
        {
        }

        public BlogDBContext(DbContextOptions<BlogDBContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<Post> Post { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=DESKTOP-UANN8KF;Database=BlogDB;UID=sa;PWD=telefon;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Post>(entity =>
            {

                entity.Property(e => e.PostId).HasColumnName("POST_ID");

                
                entity.Property(e => e.Slug)
                  .HasColumnName("SLUG")
                  .HasMaxLength(1000)
                  .IsUnicode(false);


                entity.Property(e => e.Title)
                  .HasColumnName("TITLE")
                  .HasMaxLength(2000)
                  .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);
                             
                entity.Property(e => e.Body)
                    .HasColumnName("BODY")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TagList)
                    .HasColumnName("TAG_LIST")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                  .HasColumnName("CREATED_AT")
                  .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("UPDATED_AT")
                    .HasColumnType("datetime");

               
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
