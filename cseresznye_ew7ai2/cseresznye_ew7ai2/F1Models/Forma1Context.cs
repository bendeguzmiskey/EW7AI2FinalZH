using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace cseresznye_ew7ai2.F1Models;

public partial class Forma1Context : DbContext
{
    public Forma1Context()
    {
    }

    public Forma1Context(DbContextOptions<Forma1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Csapat> Csapat { get; set; }

    public virtual DbSet<Eredmeny> Eredmeny { get; set; }

    public virtual DbSet<Pilota> Pilota { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:softeng-projekt.database.windows.net,1433;Initial Catalog=Forma1;Persist Security Info=False;User ID=gipszjakab;Password=Password12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Csapat>(entity =>
        {
            entity.HasKey(e => e.CsapatId).HasName("PK__Csapat__3F6BFE72A1D5588F");

            entity.Property(e => e.CsapatId).HasColumnName("CsapatID");
            entity.Property(e => e.Nev).HasMaxLength(100);
            entity.Property(e => e.Szponzor).HasMaxLength(100);
        });

        modelBuilder.Entity<Eredmeny>(entity =>
        {
            entity.HasKey(e => e.EredmenyId).HasName("PK__Eredmeny__8B79D5E907B023BE");

            entity.Property(e => e.EredmenyId).HasColumnName("EredmenyID");
            entity.Property(e => e.CsapatId).HasColumnName("CsapatID");
            entity.Property(e => e.PilotaId).HasColumnName("PilotaID");
            entity.Property(e => e.VersenyDatum).HasColumnType("date");

            entity.HasOne(d => d.Csapat).WithMany(p => p.Eredmeny)
                .HasForeignKey(d => d.CsapatId)
                .HasConstraintName("FK_Csapat");

            entity.HasOne(d => d.Pilota).WithMany(p => p.Eredmeny)
                .HasForeignKey(d => d.PilotaId)
                .HasConstraintName("FK_Pilota");
        });

        modelBuilder.Entity<Pilota>(entity =>
        {
            entity.HasKey(e => e.PilotaId).HasName("PK__Pilota__06E25C3D21CA5599");

            entity.HasIndex(e => new { e.Nev, e.SzuletesiDatum }, "UQ_Pilota").IsUnique();

            entity.Property(e => e.PilotaId).HasColumnName("PilotaID");
            entity.Property(e => e.Nemzetiseg).HasMaxLength(50);
            entity.Property(e => e.Nev).HasMaxLength(100);
            entity.Property(e => e.SzuletesiDatum).HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
