﻿// <auto-generated />
using System;
using Escalonamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Escalonamento.Migrations
{
    [DbContext(typeof(EscalonamentoContext))]
    [Migration("20181128171325_marca")]
    partial class marca
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Escalonamento.Models.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("Escalonamento.Models.medico", b =>
                {
                    b.Property<int>("MedicoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Disponibilidade")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("NumMatricula")
                        .IsRequired();

                    b.HasKey("MedicoID");

                    b.ToTable("medico");
                });

            modelBuilder.Entity("Escalonamento.Models.Modelo", b =>
                {
                    b.Property<int>("ModeloId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Ano");

                    b.Property<int>("MarcaId");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("ModeloId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("Escalonamento.Models.Trocas", b =>
                {
                    b.Property<int>("TrocasId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dia1");

                    b.Property<DateTime>("Dia2");

                    b.Property<string>("Nome1")
                        .IsRequired();

                    b.Property<string>("Nome2")
                        .IsRequired();

                    b.Property<string>("Turno1")
                        .IsRequired();

                    b.Property<string>("Turno2")
                        .IsRequired();

                    b.HasKey("TrocasId");

                    b.ToTable("Trocas");
                });

            modelBuilder.Entity("Escalonamento.Models.Veiculos", b =>
                {
                    b.Property<int>("VeiculosId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Disponibilidade");

                    b.Property<string>("Marca")
                        .IsRequired();

                    b.Property<string>("NumMatricula")
                        .IsRequired();

                    b.HasKey("VeiculosId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("Escalonamento.Models.Modelo", b =>
                {
                    b.HasOne("Escalonamento.Models.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
