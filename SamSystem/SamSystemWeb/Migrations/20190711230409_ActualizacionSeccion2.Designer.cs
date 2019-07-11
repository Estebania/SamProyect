﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SamSystemWeb.Data;

namespace SamSystemWeb.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190711230409_ActualizacionSeccion2")]
    partial class ActualizacionSeccion2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SamSystemWeb.Data.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SamSystemWeb.Models.Articulo", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("CantidadASolicitar");

                    b.Property<short>("CantidadDisponible");

                    b.Property<short>("CantidadRequerida");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<double>("Precio");

                    b.HasKey("ID");

                    b.ToTable("Articulo");
                });

            modelBuilder.Entity("SamSystemWeb.Models.Cargo", b =>
                {
                    b.Property<short>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("id");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("SamSystemWeb.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(13);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime>("FechaNacimiento")
                        .HasMaxLength(3);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("UsuarioIDId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UsuarioIDId");

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("SamSystemWeb.Models.DetalleRetencion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("ArticulosIdID");

                    b.HasKey("ID");

                    b.HasIndex("ArticulosIdID");

                    b.ToTable("DetalleRetenciones");
                });

            modelBuilder.Entity("SamSystemWeb.Models.Estado", b =>
                {
                    b.Property<byte>("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("SamSystemWeb.Models.Estudiante", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<byte>("EstadoIdid");

                    b.Property<DateTime>("FechaDeNacimiento");

                    b.Property<short>("FormaDePagoIdID");

                    b.Property<short>("NivelIdid");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<short>("SeccionIdID");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<int>("TutorIdID");

                    b.HasKey("ID");

                    b.HasIndex("EstadoIdid");

                    b.HasIndex("FormaDePagoIdID");

                    b.HasIndex("NivelIdid");

                    b.HasIndex("SeccionIdID");

                    b.HasIndex("TutorIdID");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("SamSystemWeb.Models.Factura", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cambio");

                    b.Property<int>("CodigoFactura");

                    b.Property<double>("Efectivo");

                    b.Property<int>("EstudianteIdID");

                    b.Property<DateTime>("Fecha");

                    b.Property<double>("MontoTotal");

                    b.Property<byte>("TipoDePagoIdID");

                    b.HasKey("ID");

                    b.HasIndex("EstudianteIdID");

                    b.HasIndex("TipoDePagoIdID");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("SamSystemWeb.Models.FormaDePago", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cuota");

                    b.Property<string>("Pago")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("ID");

                    b.ToTable("FormasDePago");
                });

            modelBuilder.Entity("SamSystemWeb.Models.Maestro", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Estadoid");

                    b.Property<short>("Nivelid");

                    b.Property<int>("colaboradoridId");

                    b.HasKey("ID");

                    b.HasIndex("Estadoid");

                    b.HasIndex("Nivelid");

                    b.HasIndex("colaboradoridId");

                    b.ToTable("Maestros");
                });

            modelBuilder.Entity("SamSystemWeb.Models.Nivel", b =>
                {
                    b.Property<short>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("id");

                    b.ToTable("Niveles");
                });

            modelBuilder.Entity("SamSystemWeb.Models.Proveedor", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<byte>("EstadoIdid");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.HasKey("ID");

                    b.HasIndex("EstadoIdid");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("SamSystemWeb.Models.Retencion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("CantidadDeArticulos");

                    b.Property<byte>("EstadoIdid");

                    b.Property<int>("EstudianteIdID");

                    b.Property<double>("MontoAPagar");

                    b.HasKey("ID");

                    b.HasIndex("EstadoIdid");

                    b.HasIndex("EstudianteIdID");

                    b.ToTable("Retenciones");
                });

            modelBuilder.Entity("SamSystemWeb.Models.Seccion", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Cupo");

                    b.Property<DateTime>("Horario");

                    b.Property<short>("MaestroidID");

                    b.HasKey("ID");

                    b.HasIndex("MaestroidID");

                    b.ToTable("Secciones");
                });

            modelBuilder.Entity("SamSystemWeb.Models.TipoDePago", b =>
                {
                    b.Property<byte>("ID");

                    b.Property<string>("Pago")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("TiposDePagos");
                });

            modelBuilder.Entity("SamSystemWeb.Models.Tutor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<byte>("EstadoIdid");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nomnbre")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.HasKey("ID");

                    b.HasIndex("EstadoIdid");

                    b.ToTable("Tutores");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SamSystemWeb.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SamSystemWeb.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SamSystemWeb.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SamSystemWeb.Data.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SamSystemWeb.Models.Colaborador", b =>
                {
                    b.HasOne("SamSystemWeb.Data.AppUser", "UsuarioID")
                        .WithMany()
                        .HasForeignKey("UsuarioIDId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SamSystemWeb.Models.DetalleRetencion", b =>
                {
                    b.HasOne("SamSystemWeb.Models.Articulo", "ArticulosId")
                        .WithMany()
                        .HasForeignKey("ArticulosIdID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SamSystemWeb.Models.Estudiante", b =>
                {
                    b.HasOne("SamSystemWeb.Models.Estado", "EstadoId")
                        .WithMany()
                        .HasForeignKey("EstadoIdid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SamSystemWeb.Models.FormaDePago", "FormaDePagoId")
                        .WithMany()
                        .HasForeignKey("FormaDePagoIdID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SamSystemWeb.Models.Nivel", "NivelId")
                        .WithMany()
                        .HasForeignKey("NivelIdid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SamSystemWeb.Models.Seccion", "SeccionId")
                        .WithMany()
                        .HasForeignKey("SeccionIdID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SamSystemWeb.Models.Tutor", "TutorId")
                        .WithMany()
                        .HasForeignKey("TutorIdID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SamSystemWeb.Models.Factura", b =>
                {
                    b.HasOne("SamSystemWeb.Models.Estudiante", "EstudianteId")
                        .WithMany()
                        .HasForeignKey("EstudianteIdID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SamSystemWeb.Models.TipoDePago", "TipoDePagoId")
                        .WithMany()
                        .HasForeignKey("TipoDePagoIdID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SamSystemWeb.Models.Maestro", b =>
                {
                    b.HasOne("SamSystemWeb.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("Estadoid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SamSystemWeb.Models.Nivel", "Nivel")
                        .WithMany()
                        .HasForeignKey("Nivelid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SamSystemWeb.Models.Colaborador", "colaboradorid")
                        .WithMany()
                        .HasForeignKey("colaboradoridId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SamSystemWeb.Models.Proveedor", b =>
                {
                    b.HasOne("SamSystemWeb.Models.Estado", "EstadoId")
                        .WithMany()
                        .HasForeignKey("EstadoIdid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SamSystemWeb.Models.Retencion", b =>
                {
                    b.HasOne("SamSystemWeb.Models.Estado", "EstadoId")
                        .WithMany()
                        .HasForeignKey("EstadoIdid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SamSystemWeb.Models.Estudiante", "EstudianteId")
                        .WithMany()
                        .HasForeignKey("EstudianteIdID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SamSystemWeb.Models.Seccion", b =>
                {
                    b.HasOne("SamSystemWeb.Models.Maestro", "Maestroid")
                        .WithMany()
                        .HasForeignKey("MaestroidID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SamSystemWeb.Models.Tutor", b =>
                {
                    b.HasOne("SamSystemWeb.Models.Estado", "EstadoId")
                        .WithMany()
                        .HasForeignKey("EstadoIdid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
