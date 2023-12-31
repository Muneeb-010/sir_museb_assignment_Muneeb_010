﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assignement_muneeb.Models;

#nullable disable

namespace assignment_muneeb.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20231212140043_initial create")]
    partial class initialcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("assignment_muneeb.data.Class", b =>
                {
                    b.Property<int>("Cid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cid"));

                    b.Property<int>("FacultyFid")
                        .HasColumnType("int");

                    b.Property<int>("Fid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cid");

                    b.HasIndex("FacultyFid");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("assignment_muneeb.data.Enrolled", b =>
                {
                    b.Property<int>("Eid")
                        .HasColumnType("int");

                    b.Property<int>("Sid")
                        .HasColumnType("int");

                    b.HasKey("Eid", "Sid");

                    b.HasIndex("Sid");

                    b.ToTable("Enrolled");
                });

            modelBuilder.Entity("assignment_muneeb.data.Faculty", b =>
                {
                    b.Property<int>("Fid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Fid"));

                    b.Property<int>("Deptid")
                        .HasColumnType("int");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Standing")
                        .HasColumnType("int");

                    b.HasKey("Fid");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("assignment_muneeb.data.Mark", b =>
                {
                    b.Property<int>("MarkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarkId"));

                    b.Property<int>("EnrolledCid")
                        .HasColumnType("int");

                    b.Property<int>("EnrolledEid")
                        .HasColumnType("int");

                    b.Property<int>("EnrolledSid")
                        .HasColumnType("int");

                    b.HasKey("MarkId");

                    b.HasIndex("EnrolledEid", "EnrolledSid");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("assignment_muneeb.data.Student", b =>
                {
                    b.Property<int>("Sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Sid"));

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Standing")
                        .HasColumnType("int");

                    b.HasKey("Sid");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("assignment_muneeb.data.Class", b =>
                {
                    b.HasOne("assignment_muneeb.data.Faculty", "Faculty")
                        .WithMany("Classes")
                        .HasForeignKey("FacultyFid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("assignment_muneeb.data.Enrolled", b =>
                {
                    b.HasOne("assignment_muneeb.data.Class", "Class")
                        .WithMany("Enrolled")
                        .HasForeignKey("Sid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("assignment_muneeb.data.Student", "Student")
                        .WithMany("Enrolled")
                        .HasForeignKey("Sid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("assignment_muneeb.data.Mark", b =>
                {
                    b.HasOne("assignment_muneeb.data.Enrolled", "Enrolled")
                        .WithMany("Marks")
                        .HasForeignKey("EnrolledEid", "EnrolledSid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enrolled");
                });

            modelBuilder.Entity("assignment_muneeb.data.Class", b =>
                {
                    b.Navigation("Enrolled");
                });

            modelBuilder.Entity("assignment_muneeb.data.Enrolled", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("assignment_muneeb.data.Faculty", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("assignment_muneeb.data.Student", b =>
                {
                    b.Navigation("Enrolled");
                });
#pragma warning restore 612, 618
        }
    }
}
