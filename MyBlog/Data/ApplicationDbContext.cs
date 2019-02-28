using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyBlog.Models;

namespace MyBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PostTag>()
                .HasKey(pt => new { pt.TagId, pt.PostId });
            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.TagId);
            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.BlogPost)
                .WithMany(t => t.PostTags)
                .HasForeignKey(pt => pt.PostId);
        }

        public DbSet<BlogPost> BlogPosts { get; set; }      //creates a table of blog posts

    }
}
