﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruitCatShigavkp.Data;

#nullable disable

namespace RecruitCatShigavkp.Migrations
{
    [DbContext(typeof(RecruitCatShigavkpContext))]
    [Migration("20220918225837_Candidates1")]
    partial class Candidates1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RecruitCatShigavkp.Models.Candidate", b =>
                {
                    b.Property<int>("candidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("candidateId"), 1L, 1);

                    b.Property<int?>("Company_NamecompanyId")
                        .HasColumnType("int");

                    b.Property<int>("Industry_NameindustryId")
                        .HasColumnType("int");

                    b.Property<int>("Jobtitle_NamejobtitleId")
                        .HasColumnType("int");

                    b.Property<string>("candidateFname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("candidateLname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("targetSalary")
                        .HasColumnType("int");

                    b.HasKey("candidateId");

                    b.HasIndex("Company_NamecompanyId");

                    b.HasIndex("Industry_NameindustryId");

                    b.HasIndex("Jobtitle_NamejobtitleId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("RecruitCatShigavkp.Models.Company", b =>
                {
                    b.Property<int>("companyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("companyId"), 1L, 1);

                    b.Property<int>("Ind_NameindustryId")
                        .HasColumnType("int");

                    b.Property<string>("companyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("companyRank")
                        .HasColumnType("int");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("max_salary")
                        .HasColumnType("int");

                    b.Property<int>("min_salary")
                        .HasColumnType("int");

                    b.Property<string>("position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("start_date")
                        .HasColumnType("datetime2");

                    b.HasKey("companyId");

                    b.HasIndex("Ind_NameindustryId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("RecruitCatShigavkp.Models.Industry", b =>
                {
                    b.Property<int>("industryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("industryId"), 1L, 1);

                    b.Property<string>("industryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("industryType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("industryId");

                    b.ToTable("Industry");
                });

            modelBuilder.Entity("RecruitCatShigavkp.Models.Jobtitle", b =>
                {
                    b.Property<int>("jobtitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("jobtitleId"), 1L, 1);

                    b.Property<DateTime?>("deadLine")
                        .HasColumnType("datetime2");

                    b.Property<string>("jobType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("maxSalary")
                        .HasColumnType("int");

                    b.Property<int>("minSalary")
                        .HasColumnType("int");

                    b.Property<string>("skills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("jobtitleId");

                    b.ToTable("Jobtitle");
                });

            modelBuilder.Entity("RecruitCatShigavkp.Models.Candidate", b =>
                {
                    b.HasOne("RecruitCatShigavkp.Models.Company", "Company_Name")
                        .WithMany("Employees")
                        .HasForeignKey("Company_NamecompanyId");

                    b.HasOne("RecruitCatShigavkp.Models.Industry", "Industry_Name")
                        .WithMany("Resources")
                        .HasForeignKey("Industry_NameindustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitCatShigavkp.Models.Jobtitle", "Jobtitle_Name")
                        .WithMany("Person")
                        .HasForeignKey("Jobtitle_NamejobtitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company_Name");

                    b.Navigation("Industry_Name");

                    b.Navigation("Jobtitle_Name");
                });

            modelBuilder.Entity("RecruitCatShigavkp.Models.Company", b =>
                {
                    b.HasOne("RecruitCatShigavkp.Models.Industry", "Ind_Name")
                        .WithMany("Companies")
                        .HasForeignKey("Ind_NameindustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ind_Name");
                });

            modelBuilder.Entity("RecruitCatShigavkp.Models.Company", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("RecruitCatShigavkp.Models.Industry", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Resources");
                });

            modelBuilder.Entity("RecruitCatShigavkp.Models.Jobtitle", b =>
                {
                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
