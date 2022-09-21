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
    [Migration("20220920040241_Facturas")]
    partial class Facturas
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

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transmision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("placa_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("placa_id")
                        .IsUnique();

                    b.ToTable("autos");
                });

            modelBuilder.Entity("Dominio.Camioneta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<bool>("Platon")
                        .HasColumnType("bit");

                    b.Property<string>("Transmision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("placa_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("placa_id")
                        .IsUnique();

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

                    b.HasIndex("Factura_id");

                    b.HasIndex("Identificaion_id")
                        .IsUnique();

                    b.HasIndex("placa_id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("Dominio.Factura", b =>
                {
                    b.Property<int>("Factura_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Cambio_aceite")
                        .HasColumnType("bit");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tecnico_id")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<bool>("filtro_Gasolina")
                        .HasColumnType("bit");

                    b.Property<bool>("filtro_aire")
                        .HasColumnType("bit");

                    b.Property<int>("placa_id")
                        .HasColumnType("int");

                    b.HasKey("Factura_id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("Tecnico_id");

                    b.HasIndex("placa_id");

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
                    b.Property<int>("Tecnico_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Identificaion_id")
                        .HasColumnType("int");

                    b.HasKey("Tecnico_id");

                    b.HasIndex("Identificaion_id")
                        .IsUnique();

                    b.ToTable("tecnicos");
                });

            modelBuilder.Entity("Dominio.Vehiculo", b =>
                {
                    b.Property<int>("placa_id")
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

                    b.HasKey("placa_id");

                    b.ToTable("vehiculos");
                });

            modelBuilder.Entity("Dominio.Auto", b =>
                {
                    b.HasOne("Dominio.Cliente", null)
                        .WithMany("Autos")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Dominio.Vehiculo", "Vehiculo")
                        .WithOne("auto")
                        .HasForeignKey("Dominio.Auto", "placa_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("Dominio.Camioneta", b =>
                {
                    b.HasOne("Dominio.Cliente", null)
                        .WithMany("Camionetas")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Dominio.Vehiculo", "Vehiculo")
                        .WithOne("camioneta")
                        .HasForeignKey("Dominio.Camioneta", "placa_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("Dominio.Cliente", b =>
                {
                    b.HasOne("Dominio.Factura", "Factura")
                        .WithMany()
                        .HasForeignKey("Factura_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Persona", "Persona")
                        .WithOne("cliente")
                        .HasForeignKey("Dominio.Cliente", "Identificaion_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("placa_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factura");

                    b.Navigation("Persona");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("Dominio.Factura", b =>
                {
                    b.HasOne("Dominio.Cliente", null)
                        .WithMany("Facturas")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Dominio.Tecnico", "Tecnico")
                        .WithMany()
                        .HasForeignKey("Tecnico_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("placa_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tecnico");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("Dominio.Tecnico", b =>
                {
                    b.HasOne("Dominio.Persona", "Persona")
                        .WithOne("tecnico")
                        .HasForeignKey("Dominio.Tecnico", "Identificaion_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Dominio.Cliente", b =>
                {
                    b.Navigation("Autos");

                    b.Navigation("Camionetas");

                    b.Navigation("Facturas");
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.Navigation("cliente");

                    b.Navigation("tecnico");
                });

            modelBuilder.Entity("Dominio.Vehiculo", b =>
                {
                    b.Navigation("auto");

                    b.Navigation("camioneta");
                });
#pragma warning restore 612, 618
        }
    }
}
