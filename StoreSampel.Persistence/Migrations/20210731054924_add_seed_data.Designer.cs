﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreSampel.Persistence.Context;

namespace StoreSampel.Persistence.Migrations
{
    [DbContext(typeof(StoreSampelContext))]
    [Migration("20210731054924_add_seed_data")]
    partial class add_seed_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("StoreSampel.Domain.Entities.Brands.Brand", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 77, DateTimeKind.Local).AddTicks(6285),
                            Name = "خانواده پژو"
                        },
                        new
                        {
                            Id = 2L,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 79, DateTimeKind.Local).AddTicks(2829),
                            Name = "خانواده رنو"
                        },
                        new
                        {
                            Id = 3L,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 79, DateTimeKind.Local).AddTicks(2991),
                            Name = "خانواده پراید"
                        });
                });

            modelBuilder.Entity("StoreSampel.Domain.Entities.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BrandId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 3L,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 86, DateTimeKind.Local).AddTicks(9505),
                            Name = "111"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3L,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 87, DateTimeKind.Local).AddTicks(1767),
                            Name = "131"
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 3L,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 87, DateTimeKind.Local).AddTicks(1842),
                            Name = "141"
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 1L,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 87, DateTimeKind.Local).AddTicks(1856),
                            Name = "405GLX"
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 1L,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 87, DateTimeKind.Local).AddTicks(1868),
                            Name = "405slx"
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 2L,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 87, DateTimeKind.Local).AddTicks(1888),
                            Name = "مگان"
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 2L,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 87, DateTimeKind.Local).AddTicks(1899),
                            Name = "سانرو"
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 2L,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 87, DateTimeKind.Local).AddTicks(1911),
                            Name = "کولیوس"
                        });
                });

            modelBuilder.Entity("StoreSampel.Domain.Entities.Orders.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("BrandId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ModelId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("StoreSampel.Domain.Entities.Products.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ProductValue")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("StoreSampel.Domain.Entities.Types.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 89, DateTimeKind.Local).AddTicks(4659),
                            ModelId = 5,
                            Name = "بنزینی"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 89, DateTimeKind.Local).AddTicks(6000),
                            ModelId = 4,
                            Name = "بنزینی"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 89, DateTimeKind.Local).AddTicks(6062),
                            ModelId = 4,
                            Name = "دوگانه سوز"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 89, DateTimeKind.Local).AddTicks(6075),
                            ModelId = 1,
                            Name = "بنزینی"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 89, DateTimeKind.Local).AddTicks(6087),
                            ModelId = 1,
                            Name = "بنزینی slx"
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 89, DateTimeKind.Local).AddTicks(6154),
                            ModelId = 6,
                            Name = "بنزینی 1700cc"
                        },
                        new
                        {
                            Id = 7,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 89, DateTimeKind.Local).AddTicks(6168),
                            ModelId = 6,
                            Name = "بنزینی 2000cc"
                        },
                        new
                        {
                            Id = 8,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 89, DateTimeKind.Local).AddTicks(6180),
                            ModelId = 7,
                            Name = "بنزینی 1800cc"
                        },
                        new
                        {
                            Id = 9,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 89, DateTimeKind.Local).AddTicks(6192),
                            ModelId = 7,
                            Name = "بنزینی cross over"
                        },
                        new
                        {
                            Id = 10,
                            CreateDate = new DateTime(2021, 7, 31, 10, 19, 24, 89, DateTimeKind.Local).AddTicks(6207),
                            ModelId = 8,
                            Name = "بنزینی "
                        });
                });

            modelBuilder.Entity("StoreSampel.Domain.Identity.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("StoreSampel.Domain.Identity.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("StoreSampel.Domain.Identity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("StoreSampel.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("StoreSampel.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("StoreSampel.Domain.Identity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreSampel.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("StoreSampel.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StoreSampel.Domain.Entities.Models.Model", b =>
                {
                    b.HasOne("StoreSampel.Domain.Entities.Brands.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("StoreSampel.Domain.Entities.Orders.Order", b =>
                {
                    b.HasOne("StoreSampel.Domain.Entities.Brands.Brand", "Brand")
                        .WithMany("Orders")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StoreSampel.Domain.Entities.Models.Model", "Model")
                        .WithMany("Orders")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StoreSampel.Domain.Entities.Types.Type", "Type")
                        .WithMany("Orders")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StoreSampel.Domain.Identity.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StoreSampel.Domain.Entities.Products.Product", b =>
                {
                    b.HasOne("StoreSampel.Domain.Entities.Orders.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("StoreSampel.Domain.Entities.Types.Type", b =>
                {
                    b.HasOne("StoreSampel.Domain.Entities.Models.Model", "Model")
                        .WithMany("Types")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
