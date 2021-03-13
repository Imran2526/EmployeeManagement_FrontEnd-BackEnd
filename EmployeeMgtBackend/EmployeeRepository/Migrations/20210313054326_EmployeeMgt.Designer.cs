﻿// <auto-generated />
using EmployeeRepositoryLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeRepositoryLayer.Migrations
{
    [DbContext(typeof(EmployeeDBContext))]
    [Migration("20210313054326_EmployeeMgt")]
    partial class EmployeeMgt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeModel.EmployeeModels", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<long>("Mobile");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<long>("Zip");

                    b.HasKey("EmployeeId");

                    b.ToTable("EmployeeTable");
                });
#pragma warning restore 612, 618
        }
    }
}
