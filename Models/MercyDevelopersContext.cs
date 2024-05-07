using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace EV1_U1_Felipe_Castillo.Models;

public partial class MercyDevelopersContext : DbContext
{
    public MercyDevelopersContext()
    {
    }

    public MercyDevelopersContext(DbContextOptions<MercyDevelopersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PRIMARY");

            entity.ToTable("clientes");

            entity.Property(e => e.IdCliente)
                .HasColumnType("int(11)")
                .HasColumnName("id_cliente");
            entity.Property(e => e.ApellidoMaternoCliente)
                .HasMaxLength(45)
                .HasColumnName("apellido_materno_cliente");
            entity.Property(e => e.ApellidoPaternoCliente)
                .HasMaxLength(45)
                .HasColumnName("apellido_paterno_cliente");
            entity.Property(e => e.CorreoCliente)
                .HasMaxLength(45)
                .HasColumnName("correo_cliente");
            entity.Property(e => e.DireccionCliente)
                .HasMaxLength(45)
                .HasColumnName("direccion_cliente");
            entity.Property(e => e.FechaInscripcionCliente)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inscripcion_cliente");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(45)
                .HasColumnName("nombre_cliente");
            entity.Property(e => e.RutCliente)
                .HasMaxLength(45)
                .HasColumnName("rut_cliente");
            entity.Property(e => e.TelefonoCliente)
                .HasMaxLength(45)
                .HasColumnName("telefono_cliente");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicio).HasName("PRIMARY");

            entity.ToTable("servicios");

            entity.Property(e => e.IdServicio)
                .HasColumnType("int(11)")
                .HasColumnName("id_servicio");
            entity.Property(e => e.DescServicio)
                .HasMaxLength(45)
                .HasColumnName("desc_servicio");
            entity.Property(e => e.FechaInicioServicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio_servicio");
            entity.Property(e => e.FechaTerminoServicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_termino_servicio");
            entity.Property(e => e.PrecioServicio)
                .HasColumnType("int(11)")
                .HasColumnName("precio_servicio");
            entity.Property(e => e.RutCliente)
                .HasMaxLength(45)
                .HasColumnName("rut_cliente");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
