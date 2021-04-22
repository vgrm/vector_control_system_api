﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VectorIdentityAPI.Database;

namespace VectorIdentityAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210422041404_UpdateMatches2")]
    partial class UpdateMatches2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VectorIdentityAPI.Database.Arc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AngleEnd")
                        .HasColumnType("float")
                        .HasColumnName("angle_end");

                    b.Property<double>("AngleStart")
                        .HasColumnType("float")
                        .HasColumnName("angle_start");

                    b.Property<double>("DX")
                        .HasColumnType("float")
                        .HasColumnName("dx");

                    b.Property<double>("DY")
                        .HasColumnType("float")
                        .HasColumnName("dy");

                    b.Property<double>("DZ")
                        .HasColumnType("float")
                        .HasColumnName("dz");

                    b.Property<string>("Handle")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("handle");

                    b.Property<string>("Layer")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("layer");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnName("project_id");

                    b.Property<double>("Radius")
                        .HasColumnType("float")
                        .HasColumnName("radius");

                    b.Property<double>("X")
                        .HasColumnType("float")
                        .HasColumnName("x");

                    b.Property<double>("Y")
                        .HasColumnType("float")
                        .HasColumnName("y");

                    b.Property<double>("Z")
                        .HasColumnType("float")
                        .HasColumnName("z");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("arc");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.ComparisonData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ComparisonData");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.Line", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DX")
                        .HasColumnType("float")
                        .HasColumnName("dx");

                    b.Property<double>("DY")
                        .HasColumnType("float")
                        .HasColumnName("dy");

                    b.Property<double>("DZ")
                        .HasColumnType("float")
                        .HasColumnName("dz");

                    b.Property<string>("Handle")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("handle");

                    b.Property<string>("Layer")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("layer");

                    b.Property<double>("Magnitude")
                        .HasColumnType("float")
                        .HasColumnName("magnitude");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnName("project_id");

                    b.Property<double>("X1")
                        .HasColumnType("float")
                        .HasColumnName("x1");

                    b.Property<double>("X2")
                        .HasColumnType("float")
                        .HasColumnName("x2");

                    b.Property<double>("Y1")
                        .HasColumnType("float")
                        .HasColumnName("y1");

                    b.Property<double>("Y2")
                        .HasColumnType("float")
                        .HasColumnName("y2");

                    b.Property<double>("Z1")
                        .HasColumnType("float")
                        .HasColumnName("z1");

                    b.Property<double>("Z2")
                        .HasColumnType("float")
                        .HasColumnName("z2");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("line");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArcId")
                        .HasColumnType("int");

                    b.Property<int>("ArcOriginalId")
                        .HasColumnType("int")
                        .HasColumnName("arc_original_id");

                    b.Property<int>("ArcTestId")
                        .HasColumnType("int")
                        .HasColumnName("arc_test_id");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("info");

                    b.Property<int>("LineOriginalId")
                        .HasColumnType("int")
                        .HasColumnName("line_original_id");

                    b.Property<int>("LineTestId")
                        .HasColumnType("int")
                        .HasColumnName("line_test_id");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<int>("OriginalProjectId")
                        .HasColumnType("int")
                        .HasColumnName("original_project_id");

                    b.Property<int>("TestProjectId")
                        .HasColumnType("int")
                        .HasColumnName("test_project_id");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.HasIndex("ArcId");

                    b.HasIndex("ArcOriginalId");

                    b.HasIndex("ArcTestId");

                    b.HasIndex("LineOriginalId");

                    b.HasIndex("LineTestId");

                    b.HasIndex("OriginalProjectId");

                    b.HasIndex("TestProjectId");

                    b.ToTable("match");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.ProjectData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("date")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("date")
                        .HasColumnName("date_updated");

                    b.Property<DateTime>("DateUploaded")
                        .HasColumnType("date")
                        .HasColumnName("date_uploaded");

                    b.Property<byte[]>("FileData")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("file_data");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("file_type");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<bool>("Original")
                        .HasColumnType("bit")
                        .HasColumnName("original");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int")
                        .HasColumnName("owner_id");

                    b.Property<int>("ProjectSetId")
                        .HasColumnType("int")
                        .HasColumnName("projectset_id");

                    b.Property<double>("ScoreCorrectness")
                        .HasColumnType("float")
                        .HasColumnName("score_correctness");

                    b.Property<double>("ScoreIdentity")
                        .HasColumnType("float")
                        .HasColumnName("score_identity");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ProjectSetId");

                    b.ToTable("projectdata");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.ProjectSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int")
                        .HasColumnName("owner_id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("projectset");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("firstname");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lastname");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password_hash");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password_salt");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("user_data_email_key");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasDatabaseName("user_data_username_key");

                    b.ToTable("user_data");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.Arc", b =>
                {
                    b.HasOne("VectorIdentityAPI.Database.ProjectData", "Project")
                        .WithMany("Arcs")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("arc_projectdata_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.Line", b =>
                {
                    b.HasOne("VectorIdentityAPI.Database.ProjectData", "Project")
                        .WithMany("Lines")
                        .HasForeignKey("ProjectId")
                        .HasConstraintName("line_projectdata_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.Match", b =>
                {
                    b.HasOne("VectorIdentityAPI.Database.Arc", null)
                        .WithMany("TestMatches")
                        .HasForeignKey("ArcId");

                    b.HasOne("VectorIdentityAPI.Database.Arc", "ArcOriginal")
                        .WithMany("OriginalMatches")
                        .HasForeignKey("ArcOriginalId")
                        .HasConstraintName("match_arc_original_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VectorIdentityAPI.Database.Arc", "ArcTest")
                        .WithMany()
                        .HasForeignKey("ArcTestId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VectorIdentityAPI.Database.Line", "LineOriginal")
                        .WithMany()
                        .HasForeignKey("LineOriginalId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VectorIdentityAPI.Database.Line", "LineTest")
                        .WithMany()
                        .HasForeignKey("LineTestId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VectorIdentityAPI.Database.ProjectData", "OriginalProject")
                        .WithMany("OriginalMatches")
                        .HasForeignKey("OriginalProjectId")
                        .HasConstraintName("match_originalprojectdata_id_fkey")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VectorIdentityAPI.Database.ProjectData", "TestProject")
                        .WithMany("TestMatches")
                        .HasForeignKey("TestProjectId")
                        .HasConstraintName("match_testprojectdata_id_fkey")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ArcOriginal");

                    b.Navigation("ArcTest");

                    b.Navigation("LineOriginal");

                    b.Navigation("LineTest");

                    b.Navigation("OriginalProject");

                    b.Navigation("TestProject");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.ProjectData", b =>
                {
                    b.HasOne("VectorIdentityAPI.Database.User", "Owner")
                        .WithMany("Projects")
                        .HasForeignKey("OwnerId")
                        .HasConstraintName("projectdata_owner_id_fkey")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("VectorIdentityAPI.Database.ProjectSet", "ProjectSet")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectSetId")
                        .HasConstraintName("projectdata_projectset_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("ProjectSet");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.ProjectSet", b =>
                {
                    b.HasOne("VectorIdentityAPI.Database.User", "Owner")
                        .WithMany("ProjectSets")
                        .HasForeignKey("OwnerId")
                        .HasConstraintName("projectset_owner_id_fkey")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.Arc", b =>
                {
                    b.Navigation("OriginalMatches");

                    b.Navigation("TestMatches");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.ProjectData", b =>
                {
                    b.Navigation("Arcs");

                    b.Navigation("Lines");

                    b.Navigation("OriginalMatches");

                    b.Navigation("TestMatches");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.ProjectSet", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("VectorIdentityAPI.Database.User", b =>
                {
                    b.Navigation("Projects");

                    b.Navigation("ProjectSets");
                });
#pragma warning restore 612, 618
        }
    }
}
