using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsEFApp.Models;

public partial class Ajppablab2Context : DbContext
{
    public Ajppablab2Context()
    {
    }

    public Ajppablab2Context(DbContextOptions<Ajppablab2Context> options)
        : base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }

    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LOCALHOST\\LOCALDATABASE;Database=AJPPABLAB2;User ID=Administrator;Password=cisco123!L;Encrypt=False;TrustServerCertificate=True");
        optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.ToTable("Author");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Name).IsUnicode(false);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.ToTable("Book");

            entity.Property(e => e.Name).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
