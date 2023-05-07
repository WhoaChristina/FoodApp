using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.Models;

public partial class RestaurantDbContext : DbContext
{
    public RestaurantDbContext()
    {
    }

    public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dish> Dishes { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Restaurant-DB;Trusted_Connection=True;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dish>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.Ingredients).HasMaxLength(300);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

            entity.HasOne(d => d.Restaurant).WithMany()
                .HasForeignKey(d => d.RestaurantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Dishes_Restaurants");
        });

        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Comment).HasMaxLength(300);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
