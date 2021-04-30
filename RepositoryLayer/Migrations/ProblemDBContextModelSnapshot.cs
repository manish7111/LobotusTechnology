﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer.UserContext;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(ProblemDBContext))]
    partial class ProblemDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ModelLayer.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired();

                    b.Property<int>("DirectionId");

                    b.HasKey("CityId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("ModelLayer.Direction", b =>
                {
                    b.Property<int>("DirectionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DirectionName")
                        .IsRequired();

                    b.HasKey("DirectionId");

                    b.ToTable("Direction");
                });

            modelBuilder.Entity("ModelLayer.Rate", b =>
                {
                    b.Property<int>("RateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Kg");

                    b.Property<int>("Z1");

                    b.Property<int>("Z2");

                    b.Property<int>("Z3");

                    b.Property<int>("Z4");

                    b.HasKey("RateId");

                    b.ToTable("Rate");
                });

            modelBuilder.Entity("ModelLayer.Zone", b =>
                {
                    b.Property<int>("ZoneId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("East")
                        .IsRequired();

                    b.Property<string>("North")
                        .IsRequired();

                    b.Property<string>("South")
                        .IsRequired();

                    b.Property<string>("West")
                        .IsRequired();

                    b.Property<string>("ZoneName")
                        .IsRequired();

                    b.HasKey("ZoneId");

                    b.ToTable("Zone");
                });
#pragma warning restore 612, 618
        }
    }
}
