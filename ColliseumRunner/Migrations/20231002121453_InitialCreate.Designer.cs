﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ColliseumRunner.Migrations
{
    [DbContext(typeof(ExperimentalConditionsContext))]
    [Migration("20231002121453_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("ExperimentalConditions", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("deck1")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Deck1");

                    b.Property<string>("deck2")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Deck2");

                    b.HasKey("id");

                    b.ToTable("ExperimentalConditions");
                });
#pragma warning restore 612, 618
        }
    }
}
