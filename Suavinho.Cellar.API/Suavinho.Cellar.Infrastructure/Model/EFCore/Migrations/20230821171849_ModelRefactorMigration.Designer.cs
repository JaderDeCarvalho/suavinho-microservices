﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Suavinho.Cellar.Infrastructure.Model.EFCore;

#nullable disable

namespace Suavinho.Cellar.Infrastructure.Model.EFCore.Migrations
{
    [DbContext(typeof(CellarDataContext))]
    [Migration("20230821171849_ModelRefactorMigration")]
    partial class ModelRefactorMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Suavinho.Cellar.Domain.Entity.Cellar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cellars");
                });

            modelBuilder.Entity("Suavinho.Cellar.Domain.Entity.CellarWine", b =>
                {
                    b.Property<int>("CellarId")
                        .HasColumnType("integer");

                    b.Property<int>("WineId")
                        .HasColumnType("integer");

                    b.HasKey("CellarId", "WineId");

                    b.HasIndex("WineId");

                    b.ToTable("CellarWine");
                });

            modelBuilder.Entity("Suavinho.Cellar.Domain.Entity.Wine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AlcoholContent")
                        .HasColumnType("integer");

                    b.Property<string>("Grapes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsBarrelAged")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<int>("Vintage")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Wines");
                });

            modelBuilder.Entity("Suavinho.Cellar.Domain.Entity.CellarWine", b =>
                {
                    b.HasOne("Suavinho.Cellar.Domain.Entity.Cellar", "Cellar")
                        .WithMany("CellarWine")
                        .HasForeignKey("CellarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Suavinho.Cellar.Domain.Entity.Wine", "Wine")
                        .WithMany("CellarWine")
                        .HasForeignKey("WineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cellar");

                    b.Navigation("Wine");
                });

            modelBuilder.Entity("Suavinho.Cellar.Domain.Entity.Cellar", b =>
                {
                    b.Navigation("CellarWine");
                });

            modelBuilder.Entity("Suavinho.Cellar.Domain.Entity.Wine", b =>
                {
                    b.Navigation("CellarWine");
                });
#pragma warning restore 612, 618
        }
    }
}
