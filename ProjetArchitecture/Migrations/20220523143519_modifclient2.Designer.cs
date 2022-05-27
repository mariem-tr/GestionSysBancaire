﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetArchitecture.Data;

#nullable disable

namespace ProjetArchitecture.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220523143519_modifclient2")]
    partial class modifclient2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetArchitecture.Models.BankModels.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClient"), 1L, 1);

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientType")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumCIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumTel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdClient");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ProjetArchitecture.Models.BankModels.Compte", b =>
                {
                    b.Property<int>("CompteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompteId"), 1L, 1);

                    b.Property<int>("CompteType")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdClient")
                        .HasColumnType("int");

                    b.Property<string>("Matricule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompteId");

                    b.HasIndex("IdClient");

                    b.ToTable("Comptes");
                });

            modelBuilder.Entity("ProjetArchitecture.Models.BankModels.Compte", b =>
                {
                    b.HasOne("ProjetArchitecture.Models.BankModels.Client", "PropCompte")
                        .WithMany("ListCompte")
                        .HasForeignKey("IdClient");

                    b.Navigation("PropCompte");
                });

            modelBuilder.Entity("ProjetArchitecture.Models.BankModels.Client", b =>
                {
                    b.Navigation("ListCompte");
                });
#pragma warning restore 612, 618
        }
    }
}
