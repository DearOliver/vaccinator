﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vaccinator.Models;

namespace Vaccinator.Migrations
{
    [DbContext(typeof(ContextBDD))]
    [Migration("20210408091310_Initialisation_2.0")]
    partial class Initialisation_20
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Vaccinator.Models.Injection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Marque")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("PersonneId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PriseDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RappelDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("VaccinTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PersonneId");

                    b.HasIndex("VaccinTypeId");

                    b.ToTable("Injection");
                });

            modelBuilder.Entity("Vaccinator.Models.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BirthDate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexe")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<string>("Statut")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Personne");
                });

            modelBuilder.Entity("Vaccinator.Models.VaccinType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cible")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("DiscoveryYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("VaccinType");
                });

            modelBuilder.Entity("Vaccinator.Models.Injection", b =>
                {
                    b.HasOne("Vaccinator.Models.Personne", "Personne")
                        .WithMany("Injections")
                        .HasForeignKey("PersonneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vaccinator.Models.VaccinType", "VaccinType")
                        .WithMany("Injections")
                        .HasForeignKey("VaccinTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personne");

                    b.Navigation("VaccinType");
                });

            modelBuilder.Entity("Vaccinator.Models.Personne", b =>
                {
                    b.Navigation("Injections");
                });

            modelBuilder.Entity("Vaccinator.Models.VaccinType", b =>
                {
                    b.Navigation("Injections");
                });
#pragma warning restore 612, 618
        }
    }
}
