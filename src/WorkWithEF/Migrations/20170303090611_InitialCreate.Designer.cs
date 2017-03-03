using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WorkWithEF.Models;

namespace WorkWithEF.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20170303090611_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorkWithEF.Models.Bug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Bugs");
                });

            modelBuilder.Entity("WorkWithEF.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StatusTitle");

                    b.HasKey("StatusID");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("WorkWithEF.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Performer");

                    b.Property<int?>("StatusID");

                    b.HasKey("Id");

                    b.HasIndex("StatusID");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("WorkWithEF.Models.Task", b =>
                {
                    b.HasOne("WorkWithEF.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID");
                });
        }
    }
}
