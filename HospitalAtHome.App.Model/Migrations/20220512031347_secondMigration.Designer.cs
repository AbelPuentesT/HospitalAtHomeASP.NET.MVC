﻿// <auto-generated />
using System;
using HospitalAtHome.App.Model.AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospitalAtHome.App.Model.Migrations
{
    [DbContext(typeof(myAppContext))]
    [Migration("20220512031347_secondMigration")]
    partial class secondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HospitalAtHome.App.Controller.MedicalRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Around")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SuggestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SuggestionId");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("HospitalAtHome.App.Controller.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("HospitalAtHome.App.Controller.Suggestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suggestions");
                });

            modelBuilder.Entity("HospitalAtHome.App.Controller.VitalSign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VitalSigns");
                });

            modelBuilder.Entity("HospitalAtHome.App.Controller.DesignatedFamilyMember", b =>
                {
                    b.HasBaseType("HospitalAtHome.App.Controller.Person");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relationship")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("DesignatedFamilyMember");
                });

            modelBuilder.Entity("HospitalAtHome.App.Controller.Medical", b =>
                {
                    b.HasBaseType("HospitalAtHome.App.Controller.Person");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Medical");
                });

            modelBuilder.Entity("HospitalAtHome.App.Controller.Nurse", b =>
                {
                    b.HasBaseType("HospitalAtHome.App.Controller.Person");

                    b.Property<string>("ProfessionalCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkingHours")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Nurse");
                });

            modelBuilder.Entity("HospitalAtHome.App.Controller.Patient", b =>
                {
                    b.HasBaseType("HospitalAtHome.App.Controller.Person");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DesignatedFamilyMemberId")
                        .HasColumnType("int");

                    b.Property<int?>("MedicalId")
                        .HasColumnType("int");

                    b.Property<int?>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<int?>("VitalSignId")
                        .HasColumnType("int");

                    b.HasIndex("DesignatedFamilyMemberId");

                    b.HasIndex("MedicalId");

                    b.HasIndex("MedicalRecordId");

                    b.HasIndex("VitalSignId");

                    b.HasDiscriminator().HasValue("Patient");
                });

            modelBuilder.Entity("HospitalAtHome.App.Controller.MedicalRecord", b =>
                {
                    b.HasOne("HospitalAtHome.App.Controller.Suggestion", "Suggestion")
                        .WithMany()
                        .HasForeignKey("SuggestionId");

                    b.Navigation("Suggestion");
                });

            modelBuilder.Entity("HospitalAtHome.App.Controller.Patient", b =>
                {
                    b.HasOne("HospitalAtHome.App.Controller.DesignatedFamilyMember", "DesignatedFamilyMember")
                        .WithMany()
                        .HasForeignKey("DesignatedFamilyMemberId");

                    b.HasOne("HospitalAtHome.App.Controller.Medical", "Medical")
                        .WithMany()
                        .HasForeignKey("MedicalId");

                    b.HasOne("HospitalAtHome.App.Controller.MedicalRecord", "MedicalRecord")
                        .WithMany()
                        .HasForeignKey("MedicalRecordId");

                    b.HasOne("HospitalAtHome.App.Controller.VitalSign", "VitalSign")
                        .WithMany()
                        .HasForeignKey("VitalSignId");

                    b.Navigation("DesignatedFamilyMember");

                    b.Navigation("Medical");

                    b.Navigation("MedicalRecord");

                    b.Navigation("VitalSign");
                });
#pragma warning restore 612, 618
        }
    }
}
