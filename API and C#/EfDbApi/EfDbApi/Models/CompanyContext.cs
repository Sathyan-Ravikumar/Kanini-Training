using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EfDbApi.Models;

public partial class CompanyContext : DbContext
{
    public CompanyContext()
    {
    }

    public CompanyContext(DbContextOptions<CompanyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Deptno).HasName("PK__Departme__0149C686B440257D");

            entity.ToTable("Department");

            entity.Property(e => e.Deptno).ValueGeneratedNever();
            entity.Property(e => e.Deptname)
                .HasMaxLength(30)
                .HasColumnName("deptname");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Empno).HasName("PK__Emp__AF4C318A42C9F39C");

            entity.ToTable("Emp");

            entity.Property(e => e.Empno)
                .ValueGeneratedNever()
                .HasColumnName("empno");
            entity.Property(e => e.Ename)
                .HasMaxLength(30)
                .HasColumnName("ename");

            entity.HasOne(d => d.DeptnoNavigation).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Deptno)
                .HasConstraintName("FK__Emp__Deptno__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
