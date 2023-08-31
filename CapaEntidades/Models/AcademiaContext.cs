using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CapaEntidades.Models;

public partial class AcademiaContext : DbContext
{
    public AcademiaContext()
    {
    }

    public AcademiaContext(DbContextOptions<AcademiaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AlumnosInscripcione> AlumnosInscripciones { get; set; }

    public virtual DbSet<Comisione> Comisiones { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<DocentesCurso> DocentesCursos { get; set; }

    public virtual DbSet<Especialidade> Especialidades { get; set; }

    public virtual DbSet<Materia> Materias { get; set; }

    public virtual DbSet<Modulo> Modulos { get; set; }

    public virtual DbSet<ModulosUsuario> ModulosUsuarios { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Plane> Planes { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:academianet.database.windows.net,1433;Initial Catalog=Academia;Persist Security Info=False;User ID=netadmin;Password=Qwer1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AlumnosInscripcione>(entity =>
        {
            entity.HasKey(e => e.IdInscripcion).HasName("PK__alumnos___CB0117BA9C5C2E38");

            entity.ToTable("alumnos_inscripciones");

            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("condicion");
            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.Nota).HasColumnName("nota");

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany(p => p.AlumnosInscripciones)
                .HasForeignKey(d => d.IdAlumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__alumnos_i__id_al__71D1E811");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.AlumnosInscripciones)
                .HasForeignKey(d => d.IdCurso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__alumnos_i__id_cu__72C60C4A");
        });

        modelBuilder.Entity<Comisione>(entity =>
        {
            entity.HasKey(e => e.IdComision).HasName("PK__comision__B25ABED0E789E813");

            entity.ToTable("comisiones");

            entity.Property(e => e.IdComision).HasColumnName("id_comision");
            entity.Property(e => e.AnioEspecialidad).HasColumnName("anio_especialidad");
            entity.Property(e => e.DescComision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desc_comision");
            entity.Property(e => e.IdPlan).HasColumnName("id_plan");

            entity.HasOne(d => d.IdPlanNavigation).WithMany(p => p.Comisiones)
                .HasForeignKey(d => d.IdPlan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__comisione__id_pl__68487DD7");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.IdCurso).HasName("PK__cursos__5D3F75022613A6B2");

            entity.ToTable("cursos");

            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.AnioCalendario).HasColumnName("anio_calendario");
            entity.Property(e => e.Cupo).HasColumnName("cupo");
            entity.Property(e => e.IdComision).HasColumnName("id_comision");
            entity.Property(e => e.IdMateria).HasColumnName("id_materia");

            entity.HasOne(d => d.IdComisionNavigation).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.IdComision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__cursos__id_comis__6EF57B66");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.IdMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__cursos__id_mater__6E01572D");
        });

        modelBuilder.Entity<DocentesCurso>(entity =>
        {
            entity.HasKey(e => e.IdDictado).HasName("PK__docentes__D4981A5E4ECF0A92");

            entity.ToTable("docentes_cursos");

            entity.Property(e => e.IdDictado).HasColumnName("id_dictado");
            entity.Property(e => e.Cargo).HasColumnName("cargo");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.IdDocente).HasColumnName("id_docente");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.DocentesCursos)
                .HasForeignKey(d => d.IdCurso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__docentes___id_cu__75A278F5");

            entity.HasOne(d => d.IdDocenteNavigation).WithMany(p => p.DocentesCursos)
                .HasForeignKey(d => d.IdDocente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__docentes___id_do__76969D2E");
        });

        modelBuilder.Entity<Especialidade>(entity =>
        {
            entity.HasKey(e => e.IdEspecialidad).HasName("PK__especial__C1D13763B9177BF3");

            entity.ToTable("especialidades");

            entity.Property(e => e.IdEspecialidad).HasColumnName("id_especialidad");
            entity.Property(e => e.DescEspecialidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desc_especialidad");
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.IdMateria).HasName("PK__materias__7E03FD39154CEF9F");

            entity.ToTable("materias");

            entity.Property(e => e.IdMateria).HasColumnName("id_materia");
            entity.Property(e => e.DescMateria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desc_materia");
            entity.Property(e => e.HsSemanales).HasColumnName("hs_semanales");
            entity.Property(e => e.HsTotales).HasColumnName("hs_totales");
            entity.Property(e => e.IdPlan).HasColumnName("id_plan");

            entity.HasOne(d => d.IdPlanNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdPlan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__materias__id_pla__6B24EA82");
        });

        modelBuilder.Entity<Modulo>(entity =>
        {
            entity.HasKey(e => e.IdModulo).HasName("PK__modulos__B2584DFCB91A0FE2");

            entity.ToTable("modulos");

            entity.Property(e => e.IdModulo).HasColumnName("id_modulo");
            entity.Property(e => e.DescModulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desc_modulo");
            entity.Property(e => e.Ejecuta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ejecuta");
        });

        modelBuilder.Entity<ModulosUsuario>(entity =>
        {
            entity.HasKey(e => e.IdModuloUsuario).HasName("PK__modulos___FD4A960EB0B3F213");

            entity.ToTable("modulos_usuario");

            entity.Property(e => e.IdModuloUsuario).HasColumnName("id_modulo_usuario");
            entity.Property(e => e.Alta).HasColumnName("alta");
            entity.Property(e => e.Baja).HasColumnName("baja");
            entity.Property(e => e.Consulta).HasColumnName("consulta");
            entity.Property(e => e.IdModulo).HasColumnName("id_modulo");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Modificacion).HasColumnName("modificacion");

            entity.HasOne(d => d.IdModuloNavigation).WithMany(p => p.ModulosUsuarios)
                .HasForeignKey(d => d.IdModulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__modulos_u__id_mo__797309D9");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.ModulosUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__modulos_u__id_us__7A672E12");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("PK__personas__228148B002CFE74D");

            entity.ToTable("personas");

            entity.Property(e => e.IdPersona).HasColumnName("id_persona");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.FechaNac)
                .HasColumnType("date")
                .HasColumnName("fecha_nac");
            entity.Property(e => e.IdPlan).HasColumnName("id_plan");
            entity.Property(e => e.Legajo).HasColumnName("legajo");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoPersona).HasColumnName("tipo_persona");

            entity.HasOne(d => d.IdPlanNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdPlan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Personas_Planes");
        });

        modelBuilder.Entity<Plane>(entity =>
        {
            entity.HasKey(e => e.IdPlan).HasName("PK__planes__3901EAE3D3C2AC31");

            entity.ToTable("planes");

            entity.Property(e => e.IdPlan).HasColumnName("id_plan");
            entity.Property(e => e.DescPlan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desc_plan");
            entity.Property(e => e.IdEspecialidad).HasColumnName("id_especialidad");

            entity.HasOne(d => d.IdEspecialidadNavigation).WithMany(p => p.Planes)
                .HasForeignKey(d => d.IdEspecialidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__planes__id_espec__656C112C");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__usuarios__4E3E04ADAC45757F");

            entity.ToTable("usuarios");

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CambiaClave).HasColumnName("cambia_clave");
            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Habilitado).HasColumnName("habilitado");
            entity.Property(e => e.IdPersona).HasColumnName("id_persona");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_usuario");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usuarios__id_per__628FA481");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
