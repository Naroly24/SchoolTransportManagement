﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolTransportManagement.Infrastructure;

#nullable disable

namespace SchoolTransportManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241024123531_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolTransportManagement.Domain.Conductor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenciaConducir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conductores");
                });

            modelBuilder.Entity("SchoolTransportManagement.Domain.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RutaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RutaId");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("SchoolTransportManagement.Domain.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Pagado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("SchoolTransportManagement.Domain.Ruta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreRuta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rutas");
                });

            modelBuilder.Entity("SchoolTransportManagement.Domain.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ConductorId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConductorId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("SchoolTransportManagement.Domain.Estudiante", b =>
                {
                    b.HasOne("SchoolTransportManagement.Domain.Ruta", "Ruta")
                        .WithMany("Estudiantes")
                        .HasForeignKey("RutaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ruta");
                });

            modelBuilder.Entity("SchoolTransportManagement.Domain.Pago", b =>
                {
                    b.HasOne("SchoolTransportManagement.Domain.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estudiante");
                });

            modelBuilder.Entity("SchoolTransportManagement.Domain.Vehiculo", b =>
                {
                    b.HasOne("SchoolTransportManagement.Domain.Conductor", "Conductor")
                        .WithMany("Vehiculos")
                        .HasForeignKey("ConductorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conductor");
                });

            modelBuilder.Entity("SchoolTransportManagement.Domain.Conductor", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("SchoolTransportManagement.Domain.Ruta", b =>
                {
                    b.Navigation("Estudiantes");
                });
#pragma warning restore 612, 618
        }
    }
}