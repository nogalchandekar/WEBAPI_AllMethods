using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WEB_API3.Models
{
    public partial class NogalContext : DbContext
    {
        public NogalContext()
        {
        }

        public NogalContext(DbContextOptions<NogalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblPerson> TblPeople { get; set; } = null!;
        public virtual DbSet<TblStudent> TblStudents { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TblPerson>(entity =>
        //    {
        //        entity.HasKey(e => e.RollNo)
        //            .HasName("PK__tbl_Peop__28B6684DBACA1C9C");

        //        entity.ToTable("tbl_People");

        //        entity.Property(e => e.RollNo).HasColumnName("Roll_NO");

        //        entity.Property(e => e.Department)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Fees).HasColumnType("decimal(18, 0)");

        //        entity.Property(e => e.FirstName)
        //            .HasMaxLength(50)
        //            .IsUnicode(false)
        //            .HasColumnName("First_Name");

        //        entity.Property(e => e.Gender)
        //            .HasMaxLength(40)
        //            .IsUnicode(false);

        //        entity.Property(e => e.LastName)
        //            .HasMaxLength(50)
        //            .IsUnicode(false)
        //            .HasColumnName("Last_Name");

        //        entity.Property(e => e.Status)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<TblStudent>(entity =>
        //    {
        //        entity.ToTable("tbl_Student");

        //        entity.Property(e => e.Id).HasColumnName("ID");

        //        entity.Property(e => e.Department)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Email)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.FirstName)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Gender)
        //            .HasMaxLength(30)
        //            .IsUnicode(false);

        //        entity.Property(e => e.LastName)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Password)
        //            .HasMaxLength(60)
        //            .IsUnicode(false);
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

       // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
