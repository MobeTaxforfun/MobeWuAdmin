using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MobeAdmin.API.Models.MSSQL.Entities
{
    public partial class MobeAdminContext : DbContext
    {
        public MobeAdminContext()
        {
        }

        public MobeAdminContext(DbContextOptions<MobeAdminContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SysMenu> SysMenus { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=MobeAdmin;Integrated Security = true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SysMenu>(entity =>
            {
                entity.ToTable("SysMenu");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BaseCreateTime).HasColumnType("datetime");

                entity.Property(e => e.BaseModifyTime).HasColumnType("datetime");

                entity.Property(e => e.MenuIcon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuMemo).HasMaxLength(200);

                entity.Property(e => e.MenuName).HasMaxLength(50);

                entity.Property(e => e.MenuUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
