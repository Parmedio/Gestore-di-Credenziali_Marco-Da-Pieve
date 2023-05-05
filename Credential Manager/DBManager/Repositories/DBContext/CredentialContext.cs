using System;
using System.Collections.Generic;
using DBManager.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DBManager.Repositories.DBContext;

public partial class CredentialContext : DbContext
{
    public CredentialContext()
    {
    }

    public CredentialContext(DbContextOptions<CredentialContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Data Source=ACADEMYNETUD01\\SQLEXPRESS;Initial Catalog=CREDENTIALS; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UsersID__PrimaryKey");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationDate)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
