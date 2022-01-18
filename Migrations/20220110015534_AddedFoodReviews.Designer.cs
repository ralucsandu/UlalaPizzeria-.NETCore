﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backendProiect.Entities;

namespace backendProiect.Migrations
{
    [DbContext(typeof(backendProiectContext))]
    [Migration("20220110015534_AddedFoodReviews")]
    partial class AddedFoodReviews
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("backendProiect.Entities.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PriceId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FoodId");

                    b.HasIndex("PriceId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("backendProiect.Entities.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.HasIndex("FoodId")
                        .IsUnique();

                    b.ToTable("Images");
                });

            modelBuilder.Entity("backendProiect.Entities.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("backendProiect.Entities.Price", b =>
                {
                    b.Property<int>("PriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PriceId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("backendProiect.Entities.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("FoodId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("backendProiect.Entities.Food", b =>
                {
                    b.HasOne("backendProiect.Entities.Price", "Price")
                        .WithMany("Foods")
                        .HasForeignKey("PriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Price");
                });

            modelBuilder.Entity("backendProiect.Entities.Image", b =>
                {
                    b.HasOne("backendProiect.Entities.Food", "Food")
                        .WithOne("Image")
                        .HasForeignKey("backendProiect.Entities.Image", "FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");
                });

            modelBuilder.Entity("backendProiect.Entities.Review", b =>
                {
                    b.HasOne("backendProiect.Entities.Food", "Food")
                        .WithMany("Reviews")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");
                });

            modelBuilder.Entity("backendProiect.Entities.Food", b =>
                {
                    b.Navigation("Image");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("backendProiect.Entities.Price", b =>
                {
                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}