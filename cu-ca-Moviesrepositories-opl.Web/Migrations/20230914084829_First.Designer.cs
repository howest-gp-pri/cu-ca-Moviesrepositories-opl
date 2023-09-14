﻿// <auto-generated />
using System;
using Core_MovieShop_opl_Afst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Core_MovieShop_opl_Afst_Web.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20230914084829_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.Property<int>("ActorsId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("ActorsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("ActorMovie");

                    b.HasData(
                        new
                        {
                            ActorsId = 1,
                            MoviesId = 1
                        },
                        new
                        {
                            ActorsId = 1,
                            MoviesId = 2
                        },
                        new
                        {
                            ActorsId = 2,
                            MoviesId = 1
                        },
                        new
                        {
                            ActorsId = 2,
                            MoviesId = 2
                        },
                        new
                        {
                            ActorsId = 1,
                            MoviesId = 3
                        },
                        new
                        {
                            ActorsId = 1,
                            MoviesId = 4
                        },
                        new
                        {
                            ActorsId = 2,
                            MoviesId = 3
                        },
                        new
                        {
                            ActorsId = 2,
                            MoviesId = 4
                        });
                });

            modelBuilder.Entity("Core_MovieShop_opl_Afst_Core.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Firstname = "Brad",
                            Lastname = "Pitt"
                        },
                        new
                        {
                            Id = 2,
                            Firstname = "Julia",
                            Lastname = "Roberts"
                        });
                });

            modelBuilder.Entity("Core_MovieShop_opl_Afst_Core.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Universal"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sony"
                        });
                });

            modelBuilder.Entity("Core_MovieShop_opl_Afst_Core.Entities.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Firstname = "Martin",
                            Lastname = "Scorsese"
                        },
                        new
                        {
                            Id = 2,
                            Firstname = "Ron",
                            Lastname = "Wood"
                        });
                });

            modelBuilder.Entity("Core_MovieShop_opl_Afst_Core.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            Image = "It.jpg",
                            Price = 50.00m,
                            ReleaseDate = new DateTime(2023, 9, 14, 10, 48, 29, 291, DateTimeKind.Local).AddTicks(456),
                            Title = "It"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 2,
                            Image = "pulpfiction.jpg",
                            Price = 55.00m,
                            ReleaseDate = new DateTime(2025, 9, 14, 10, 48, 29, 291, DateTimeKind.Local).AddTicks(489),
                            Title = "Pulp fiction"
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 2,
                            Image = "getshorty.jpg",
                            Price = 55.00m,
                            ReleaseDate = new DateTime(2025, 9, 14, 10, 48, 29, 291, DateTimeKind.Local).AddTicks(493),
                            Title = "Get shorty"
                        },
                        new
                        {
                            Id = 4,
                            CompanyId = 2,
                            Image = "starwars.jpg",
                            Price = 55.00m,
                            ReleaseDate = new DateTime(2025, 9, 14, 10, 48, 29, 291, DateTimeKind.Local).AddTicks(496),
                            Title = "Star wars"
                        });
                });

            modelBuilder.Entity("Core_MovieShop_opl_Afst_Core.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 1,
                            Review = "Very good!!",
                            Score = 9,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 2,
                            Review = "good!!",
                            Score = 8,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 1,
                            Review = "Ok",
                            Score = 6,
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            MovieId = 2,
                            Review = "Average..",
                            Score = 5,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Core_MovieShop_opl_Afst_Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Firstname")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Lastname")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Firstname = "Bart",
                            Lastname = "Soete",
                            Username = "bart.soete@movierating.com"
                        },
                        new
                        {
                            Id = 2,
                            Firstname = "Karel",
                            Lastname = "Soete",
                            Username = "karel.soete@movierating.com"
                        });
                });

            modelBuilder.Entity("DirectorMovie", b =>
                {
                    b.Property<int>("DirectorsId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("DirectorsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("DirectorMovie");

                    b.HasData(
                        new
                        {
                            DirectorsId = 1,
                            MoviesId = 1
                        },
                        new
                        {
                            DirectorsId = 2,
                            MoviesId = 1
                        },
                        new
                        {
                            DirectorsId = 1,
                            MoviesId = 2
                        },
                        new
                        {
                            DirectorsId = 2,
                            MoviesId = 2
                        },
                        new
                        {
                            DirectorsId = 1,
                            MoviesId = 3
                        },
                        new
                        {
                            DirectorsId = 2,
                            MoviesId = 3
                        },
                        new
                        {
                            DirectorsId = 1,
                            MoviesId = 4
                        },
                        new
                        {
                            DirectorsId = 2,
                            MoviesId = 4
                        });
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.HasOne("Core_MovieShop_opl_Afst_Core.Entities.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core_MovieShop_opl_Afst_Core.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core_MovieShop_opl_Afst_Core.Entities.Movie", b =>
                {
                    b.HasOne("Core_MovieShop_opl_Afst_Core.Entities.Company", "Company")
                        .WithMany("Movies")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Core_MovieShop_opl_Afst_Core.Entities.Rating", b =>
                {
                    b.HasOne("Core_MovieShop_opl_Afst_Core.Entities.Movie", "Movie")
                        .WithMany("Ratings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core_MovieShop_opl_Afst_Core.Entities.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DirectorMovie", b =>
                {
                    b.HasOne("Core_MovieShop_opl_Afst_Core.Entities.Director", null)
                        .WithMany()
                        .HasForeignKey("DirectorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core_MovieShop_opl_Afst_Core.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core_MovieShop_opl_Afst_Core.Entities.Company", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Core_MovieShop_opl_Afst_Core.Entities.Movie", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("Core_MovieShop_opl_Afst_Core.Entities.User", b =>
                {
                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
