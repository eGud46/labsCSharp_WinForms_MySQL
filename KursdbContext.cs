using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KursDBWinForms;

public partial class KursdbContext : DbContext
{
    public KursdbContext()
    {
    }

    public KursdbContext(DbContextOptions<KursdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Affair> Affairs { get; set; }

    public virtual DbSet<AffairsPerson> AffairsPeople { get; set; }

    public virtual DbSet<Alias> Aliases { get; set; }

    public virtual DbSet<CriminalRecord> CriminalRecords { get; set; }

    public virtual DbSet<Dock> Docks { get; set; }

    public virtual DbSet<DocksFile> DocksFiles { get; set; }

    public virtual DbSet<DocksStatus> DocksStatuses { get; set; }

    public virtual DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;password=1234;database=kursdb", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb3_general_ci")
            .HasCharSet("utf8mb3");

        modelBuilder.Entity<Affair>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("affairs");

            entity.HasIndex(e => e.IdDocks, "id_docks_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CriminalOrNot).HasColumnName("criminal_or_not");
            entity.Property(e => e.IdDocks).HasColumnName("id_docks");
            entity.Property(e => e.Responsible)
                .HasMaxLength(64)
                .HasDefaultValueSql("'Не назначен'")
                .HasColumnName("responsible");

            entity.HasOne(d => d.IdDocksNavigation).WithMany(p => p.Affairs)
                .HasForeignKey(d => d.IdDocks)
                .HasConstraintName("id_docks_affairs");
        });

        modelBuilder.Entity<AffairsPerson>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("affairs_people");

            entity.HasIndex(e => e.IdAffairs, "id_affairs_idx");

            entity.HasIndex(e => e.IdPeople, "id_people");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAffairs).HasColumnName("id_affairs");
            entity.Property(e => e.IdPeople).HasColumnName("id_people");

            entity.HasOne(d => d.IdAffairsNavigation).WithMany(p => p.AffairsPeople)
                .HasForeignKey(d => d.IdAffairs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_affairs");

            entity.HasOne(d => d.IdPeopleNavigation).WithMany(p => p.AffairsPeople)
                .HasForeignKey(d => d.IdPeople)
                .HasConstraintName("id_people");
        });

        modelBuilder.Entity<Alias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("alias");

            entity.HasIndex(e => e.IdPeople, "id_people_alias");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alias1)
                .HasMaxLength(64)
                .HasColumnName("alias");
            entity.Property(e => e.IdPeople).HasColumnName("id_people");

            entity.HasOne(d => d.IdPeopleNavigation).WithMany(p => p.Aliases)
                .HasForeignKey(d => d.IdPeople)
                .HasConstraintName("id_people_alias");
        });

        modelBuilder.Entity<CriminalRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("criminal_records");

            entity.HasIndex(e => e.IdPeople, "id_people_criminal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CriminalRecord1)
                .HasMaxLength(64)
                .HasColumnName("criminal_record");
            entity.Property(e => e.IdPeople).HasColumnName("id_people");

            entity.HasOne(d => d.IdPeopleNavigation).WithMany(p => p.CriminalRecords)
                .HasForeignKey(d => d.IdPeople)
                .HasConstraintName("id_people_criminal");
        });

        modelBuilder.Entity<Dock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("docks");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ByWho)
                .HasMaxLength(64)
                .HasColumnName("by_who");
            entity.Property(e => e.Category)
                .HasMaxLength(64)
                .HasColumnName("category");
            entity.Property(e => e.Header)
                .HasMaxLength(64)
                .HasColumnName("header");
        });

        modelBuilder.Entity<DocksFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("docks_files");

            entity.HasIndex(e => e.IdDocks, "id_docks_files");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.File)
                .HasColumnType("blob")
                .HasColumnName("file");
            entity.Property(e => e.IdDocks).HasColumnName("id_docks");

            entity.HasOne(d => d.IdDocksNavigation).WithMany(p => p.DocksFiles)
                .HasForeignKey(d => d.IdDocks)
                .HasConstraintName("id_docks_files");
        });

        modelBuilder.Entity<DocksStatus>(entity =>
        {
            entity.HasKey(e => e.IdDocks).HasName("PRIMARY");

            entity.ToTable("docks_status");

            entity.Property(e => e.IdDocks)
                .ValueGeneratedNever()
                .HasColumnName("id_docks");
            entity.Property(e => e.Complete)
                .HasDefaultValueSql("'0'")
                .HasColumnName("complete");
            entity.Property(e => e.Deadline).HasColumnName("deadline");
            entity.Property(e => e.Executor)
                .HasMaxLength(64)
                .HasDefaultValueSql("'Не назначен'")
                .HasColumnName("executor");
            entity.Property(e => e.Responsible)
                .HasMaxLength(64)
                .HasDefaultValueSql("'Не назначен'")
                .HasColumnName("responsible");

            entity.HasOne(d => d.IdDocksNavigation).WithOne(p => p.DocksStatus)
                .HasForeignKey<DocksStatus>(d => d.IdDocks)
                .HasConstraintName("id_docks_status");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("people");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Biography)
                .HasMaxLength(512)
                .HasColumnName("biography");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.Fullname)
                .HasMaxLength(128)
                .HasColumnName("fullname");
            entity.Property(e => e.Photo)
                .HasColumnType("blob")
                .HasColumnName("photo");
            entity.Property(e => e.Print)
                .HasColumnType("blob")
                .HasColumnName("print");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
