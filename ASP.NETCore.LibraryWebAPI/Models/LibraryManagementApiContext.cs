using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCore.LibraryWebAPI.Models;

public partial class LibraryManagementApiContext : DbContext
{
    public LibraryManagementApiContext()
    {
    }

    public LibraryManagementApiContext(DbContextOptions<LibraryManagementApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Loan> Loans { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WIN-UGCST86JVC7;Database=LibraryManagementAPI;Trusted_Connection=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_Books_UserId");

            entity.Property(e => e.Isbn).HasColumnName("ISBN");

            entity.HasOne(d => d.User).WithMany(p => p.Books).HasForeignKey(d => d.UserId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
