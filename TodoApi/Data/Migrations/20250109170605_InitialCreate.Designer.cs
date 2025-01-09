﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApi.Data;

#nullable disable

namespace TodoApi.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250109170605_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TodoApi.Data.TodoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Done = false,
                            Title = ".NET kursunu tamamla"
                        },
                        new
                        {
                            Id = 2,
                            Done = false,
                            Title = "CV düzenle"
                        },
                        new
                        {
                            Id = 3,
                            Done = false,
                            Title = "Bitirme ödevini tamamla"
                        },
                        new
                        {
                            Id = 4,
                            Done = true,
                            Title = "Saygınlık kazan"
                        },
                        new
                        {
                            Id = 5,
                            Done = true,
                            Title = "İş bul"
                        },
                        new
                        {
                            Id = 6,
                            Done = true,
                            Title = "Vizeye başvur"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
