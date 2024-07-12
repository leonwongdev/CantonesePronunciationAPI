﻿// <auto-generated />
using CantonesePronunciationApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CantonesePronunciationApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240711002741_WordModelConsonantNull")]
    partial class WordModelConsonantNull
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CantonesePronunciationApi.Models.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AlternativeWord")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Consonant")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Jyutping")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Page")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Tone")
                        .HasColumnType("int");

                    b.Property<string>("Vowel")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Words");
                });
#pragma warning restore 612, 618
        }
    }
}
