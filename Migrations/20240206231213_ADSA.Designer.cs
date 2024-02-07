﻿// <auto-generated />
using APITarefas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APITarefas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240206231213_ADSA")]
    partial class ADSA
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("APITarefas.Models.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<bool>("Concluida")
                        .HasColumnType("INTEGER")
                        .HasColumnName("concluida");

                    b.Property<string>("DataCriacao")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("data_criacao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("descricao");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("responsavel");

                    b.HasKey("Id");

                    b.ToTable("Tarefa");
                });
#pragma warning restore 612, 618
        }
    }
}
