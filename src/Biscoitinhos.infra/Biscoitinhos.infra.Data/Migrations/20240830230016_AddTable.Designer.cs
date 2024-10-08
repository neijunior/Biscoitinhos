﻿// <auto-generated />
using Biscoitinhos.infra.Data.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Biscoitinhos.infra.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240830230016_AddTable")]
    partial class AddTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Biscoitinhos.domain.Entidades.UnidadeMedida", b =>
                {
                    b.Property<string>("Codigo")
                        .HasMaxLength(5)
                        .HasColumnType("varchar")
                        .HasColumnName("Codigo");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Descricao");

                    b.HasKey("Codigo");

                    b.ToTable("UnidadeMedida", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
