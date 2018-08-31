using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFTest
{
    public partial class orlContext : DbContext
    {
        public orlContext()
        {
        }

        public orlContext(DbContextOptions<orlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ElementGondole> ElementGondole { get; set; }
        public virtual DbSet<Enseigne> Enseigne { get; set; }
        public virtual DbSet<Gamme> Gamme { get; set; }
        public virtual DbSet<Magasin> Magasin { get; set; }
        public virtual DbSet<Marque> Marque { get; set; }
        public virtual DbSet<Planche> Planche { get; set; }
        public virtual DbSet<Produit> Produit { get; set; }
        public virtual DbSet<Rayon> Rayon { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
        public virtual DbSet<Visite> Visite { get; set; }

        // Unable to generate entity type for table 'planche_produit'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;database=orl;user=root;password=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ElementGondole>(entity =>
            {
                entity.ToTable("element_gondole");

                entity.HasIndex(e => e.RayonId)
                    .HasName("fk_element_gondole_Rayon1_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.RayonId)
                    .HasColumnName("Rayon_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Rayon)
                    .WithMany(p => p.ElementGondole)
                    .HasForeignKey(d => d.RayonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_element_gondole_Rayon1");
            });

            modelBuilder.Entity<Enseigne>(entity =>
            {
                entity.ToTable("enseigne");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Gamme>(entity =>
            {
                entity.ToTable("gamme");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.FamilleId)
                    .HasColumnName("Famille_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nom).HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Magasin>(entity =>
            {
                entity.ToTable("magasin");

                entity.HasIndex(e => e.EnseigneId)
                    .HasName("fk_Magasin_Enseigne1_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Adresse1).HasColumnType("varchar(150)");

                entity.Property(e => e.Adresse2).HasColumnType("varchar(150)");

                entity.Property(e => e.Adresse3).HasColumnType("varchar(150)");

                entity.Property(e => e.CodePostal)
                    .HasColumnName("Code_postal")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.EnseigneId)
                    .HasColumnName("Enseigne_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Typo).HasColumnType("varchar(150)");

                entity.Property(e => e.Ville).HasColumnType("varchar(150)");

                entity.HasOne(d => d.Enseigne)
                    .WithMany(p => p.Magasin)
                    .HasForeignKey(d => d.EnseigneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Magasin_Enseigne1");
            });

            modelBuilder.Entity<Marque>(entity =>
            {
                entity.ToTable("marque");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Addresse1)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Addresse3).HasColumnType("varchar(45)");

                entity.Property(e => e.Adresse2).HasColumnType("varchar(45)");

                entity.Property(e => e.CodePostal)
                    .IsRequired()
                    .HasColumnName("Code_postal")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Ville)
                    .IsRequired()
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Planche>(entity =>
            {
                entity.ToTable("planche");

                entity.HasIndex(e => e.ElementGondoleId)
                    .HasName("fk_Planche_element_gondole1_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ElementGondoleId)
                    .HasColumnName("element_gondole_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumPlanche)
                    .HasColumnName("Num_planche")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Rupture)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.ElementGondole)
                    .WithMany(p => p.Planche)
                    .HasForeignKey(d => d.ElementGondoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Planche_element_gondole1");
            });

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.ToTable("produit");

                entity.HasIndex(e => e.GammeId)
                    .HasName("fk_Produit_Gamme1_idx");

                entity.HasIndex(e => e.MarqueId)
                    .HasName("fk_Produit_Marque1_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CodeBarre)
                    .HasColumnName("Code_barre")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Debut).HasColumnType("varchar(45)");

                entity.Property(e => e.Fin).HasColumnType("varchar(45)");

                entity.Property(e => e.GammeId)
                    .HasColumnName("Gamme_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarqueId)
                    .HasColumnName("Marque_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Gamme)
                    .WithMany(p => p.Produit)
                    .HasForeignKey(d => d.GammeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Produit_Gamme10");

                entity.HasOne(d => d.Marque)
                    .WithMany(p => p.Produit)
                    .HasForeignKey(d => d.MarqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Produit_Marque1");
            });

            modelBuilder.Entity<Rayon>(entity =>
            {
                entity.ToTable("rayon");

                entity.HasIndex(e => e.MagasinId)
                    .HasName("fk_Rayon_Magasin1_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.MagasinId)
                    .HasColumnName("Magasin_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumRayon)
                    .HasColumnName("Num_rayon")
                    .HasColumnType("varchar(45)");

                entity.HasOne(d => d.Magasin)
                    .WithMany(p => p.Rayon)
                    .HasForeignKey(d => d.MagasinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Rayon_Magasin1");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.ToTable("utilisateur");

                entity.HasIndex(e => e.MarqueId)
                    .HasName("fk_User_Marque1_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.MarqueId)
                    .HasColumnName("Marque_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mdp)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Prenom).HasColumnType("varchar(45)");

                entity.HasOne(d => d.Marque)
                    .WithMany(p => p.Utilisateur)
                    .HasForeignKey(d => d.MarqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_User_Marque1");
            });

            modelBuilder.Entity<Visite>(entity =>
            {
                entity.ToTable("visite");

                entity.HasIndex(e => e.UserId)
                    .HasName("fk_Visite_User1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Visite)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Visite_User1");
            });
        }
    }
}
