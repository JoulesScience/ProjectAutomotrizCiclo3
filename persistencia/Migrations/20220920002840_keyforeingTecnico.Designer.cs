﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using persistencia;

namespace persistencia.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220920002840_keyforeingTecnico")]
    partial class keyforeingTecnico
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Dominio.Auto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transmision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("placa_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("autos");
                });

            modelBuilder.Entity("Dominio.Camioneta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Platon")
                        .HasColumnType("bit");

                    b.Property<string>("Transmision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("placa_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("camionetas");
                });

            modelBuilder.Entity("Dominio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Factura_id")
                        .HasColumnType("int");

                    b.Property<int>("Identificaion_id")
                        .HasColumnType("int");

                    b.Property<int>("placa_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("Dominio.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Cambio_aceite")
                        .HasColumnType("bit");

                    b.Property<int>("Cliente_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Placa_id")
                        .HasColumnType("int");

                    b.Property<int>("Tecnico_id")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<bool>("filtro_Gasolina")
                        .HasColumnType("bit");

                    b.Property<bool>("filtro_aire")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.Property<int>("Identificaion_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Identificaion_id");

                    b.ToTable("personas");
                });

            modelBuilder.Entity("Dominio.Tecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Identificaion_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tecnicos");
                });

            modelBuilder.Entity("Dominio.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cilindraje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecha_modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo_combustible")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("vehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
