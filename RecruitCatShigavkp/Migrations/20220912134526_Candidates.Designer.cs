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
    [Migration("20220912134526_Candidates")]
    partial class Candidates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RecruitCatShigavkp.Models.Candidate", b =>
                {
                    b.Property<int>("candidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("candidateId"), 1L, 1);

                    b.Property<string>("candidateFname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("candidateLname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mobileNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("targetSalary")
                        .HasColumnType("int");

                    b.HasKey("candidateId");

                    b.ToTable("Candidate");
                });
#pragma warning restore 612, 618
        }
    }
}