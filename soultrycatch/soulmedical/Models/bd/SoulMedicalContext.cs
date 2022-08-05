using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace soulmedical.Models.bd
{
    public partial class SoulMedicalContext : DbContext
    {
        public SoulMedicalContext()
        {
        }

        public SoulMedicalContext(DbContextOptions<SoulMedicalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Rol> Rols { get; set; } = null!;
        public virtual DbSet<Tblhorario> Tblhorarios { get; set; } = null!;
        public virtual DbSet<Tblnomina> Tblnominas { get; set; } = null!;
        public virtual DbSet<Tbltrabajadore> Tbltrabajadores { get; set; } = null!;
        public virtual DbSet<Tblusuario> Tblusuarios { get; set; } = null!;
        public virtual DbSet<Tblvacacione> Tblvacaciones { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// #warning  To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=soul_medical_ltd;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.Idrol)
                    .HasName("PK_rol_idrol");

                entity.ToTable("rol", "soul_medical_ltd");

                entity.Property(e => e.Idrol).HasColumnName("idrol");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Tblhorario>(entity =>
            {
                entity.HasKey(e => e.HorUserid)
                    .HasName("PK_tblhorario_hor_userid");

                entity.ToTable("tblhorario", "soul_medical_ltd");

                entity.HasIndex(e => e.TraDocumento4, "tblhorario_ibfk_1");

                entity.Property(e => e.HorUserid).HasColumnName("hor_userid");

                entity.Property(e => e.HorApellido)
                    .HasMaxLength(30)
                    .HasColumnName("hor_apellido");

                entity.Property(e => e.HorLlegada)
                    .HasPrecision(0)
                    .HasColumnName("hor_llegada");

                entity.Property(e => e.HorNombre)
                    .HasMaxLength(30)
                    .HasColumnName("hor_nombre");

                entity.Property(e => e.HorSalida)
                    .HasPrecision(0)
                    .HasColumnName("hor_salida");

                entity.Property(e => e.TraDocumento4).HasColumnName("tra_documento4");

                entity.HasOne(d => d.TraDocumento4Navigation)
                    .WithMany(p => p.Tblhorarios)
                    .HasForeignKey(d => d.TraDocumento4)
                    .HasConstraintName("tblhorario$tblhorario_ibfk_1");
            });

            modelBuilder.Entity<Tblnomina>(entity =>
            {
                entity.HasKey(e => e.Nomid)
                    .HasName("PK_tblnomina_nomid");

                entity.ToTable("tblnomina", "soul_medical_ltd");

                entity.HasIndex(e => e.TraDocumento3, "tblnomina_ibfk_1");

                entity.Property(e => e.Nomid).HasColumnName("nomid");

                entity.Property(e => e.NomApellido).HasColumnName("nom_apellido");

                entity.Property(e => e.NomCesantias).HasColumnName("nom_cesantias");

                entity.Property(e => e.NomDeduccionsalario).HasColumnName("nom_deduccionsalario");

                entity.Property(e => e.NomFin)
                    .HasColumnType("date")
                    .HasColumnName("nom_fin");

                entity.Property(e => e.NomInicio)
                    .HasColumnType("date")
                    .HasColumnName("nom_inicio");

                entity.Property(e => e.NomNombre).HasColumnName("nom_nombre");

                entity.Property(e => e.NomParafiscales).HasColumnName("nom_parafiscales");

                entity.Property(e => e.NomSalarioestipulado).HasColumnName("nom_salarioestipulado");

                entity.Property(e => e.NomSaludpension).HasColumnName("nom_saludpension");

                entity.Property(e => e.TraDocumento3).HasColumnName("tra_documento3");

                entity.HasOne(d => d.TraDocumento3Navigation)
                    .WithMany(p => p.Tblnominas)
                    .HasForeignKey(d => d.TraDocumento3)
                    .HasConstraintName("tblnomina$tblnomina_ibfk_1");
            });

            modelBuilder.Entity<Tbltrabajadore>(entity =>
            {
                entity.HasKey(e => e.TraDocumento)
                    .HasName("PK_tbltrabajadores_tra_documento");

                entity.ToTable("tbltrabajadores", "soul_medical_ltd");

                entity.HasIndex(e => e.Id, "id");

                entity.Property(e => e.TraDocumento)
                    .ValueGeneratedNever()
                    .HasColumnName("tra_documento");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.TraApellido)
                    .HasMaxLength(30)
                    .HasColumnName("tra_apellido");

                entity.Property(e => e.TraCelular)
                    .HasMaxLength(30)
                    .HasColumnName("tra_celular");

                entity.Property(e => e.TraCodigocuenta)
                    .HasMaxLength(30)
                    .HasColumnName("tra_codigocuenta");

                entity.Property(e => e.TraDireccion)
                    .HasMaxLength(30)
                    .HasColumnName("tra_direccion");

                entity.Property(e => e.TraEdad).HasColumnName("tra_edad");

                entity.Property(e => e.TraEmail)
                    .HasMaxLength(30)
                    .HasColumnName("tra_email");

                entity.Property(e => e.TraFechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("tra_fecha_nacimiento");

                entity.Property(e => e.TraNombre)
                    .HasMaxLength(30)
                    .HasColumnName("tra_nombre");
            });

            modelBuilder.Entity<Tblusuario>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK_tblusuarios_userid");

                entity.ToTable("tblusuarios", "soul_medical_ltd");

                entity.HasIndex(e => e.Idrol, "id_cargo");

                entity.HasIndex(e => e.TraDocumento2, "tblusuarios_ibfk_2");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Idrol).HasColumnName("idrol");

                entity.Property(e => e.TraDocumento2).HasColumnName("tra_documento2");

                entity.Property(e => e.Userapellido)
                    .HasMaxLength(30)
                    .HasColumnName("userapellido");

                entity.Property(e => e.Userclave)
                    .HasMaxLength(30)
                    .HasColumnName("userclave");

                entity.Property(e => e.Useremail)
                    .HasMaxLength(255)
                    .HasColumnName("useremail");

                entity.Property(e => e.Usernombre)
                    .HasMaxLength(30)
                    .HasColumnName("usernombre");

                entity.HasOne(d => d.IdrolNavigation)
                    .WithMany(p => p.Tblusuarios)
                    .HasForeignKey(d => d.Idrol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblusuarios$tblusuarios_ibfk_1");

                entity.HasOne(d => d.TraDocumento2Navigation)
                    .WithMany(p => p.Tblusuarios)
                    .HasForeignKey(d => d.TraDocumento2)
                    .HasConstraintName("tblusuarios$tblusuarios_ibfk_2");
            });

            modelBuilder.Entity<Tblvacacione>(entity =>
            {
                entity.HasKey(e => e.Vacid)
                    .HasName("PK_tblvacaciones_vacid");

                entity.ToTable("tblvacaciones", "soul_medical_ltd");

                entity.HasIndex(e => e.TraDocumento5, "tblvacaciones_ibfk_1");

                entity.Property(e => e.Vacid).HasColumnName("vacid");

                entity.Property(e => e.TraDocumento5).HasColumnName("tra_documento5");

                entity.Property(e => e.VacApellido)
                    .HasMaxLength(30)
                    .HasColumnName("vac_apellido");

                entity.Property(e => e.VacDiasadicionales).HasColumnName("vac_diasadicionales");

                entity.Property(e => e.VacDiasnormales).HasColumnName("vac_diasnormales");

                entity.Property(e => e.VacDiastotales).HasColumnName("vac_diastotales");

                entity.Property(e => e.VacFin)
                    .HasColumnType("date")
                    .HasColumnName("vac_fin");

                entity.Property(e => e.VacInicio)
                    .HasColumnType("date")
                    .HasColumnName("vac_inicio");

                entity.Property(e => e.VacNombre)
                    .HasMaxLength(30)
                    .HasColumnName("vac_nombre");

                entity.HasOne(d => d.TraDocumento5Navigation)
                    .WithMany(p => p.Tblvacaciones)
                    .HasForeignKey(d => d.TraDocumento5)
                    .HasConstraintName("tblvacaciones$tblvacaciones_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
