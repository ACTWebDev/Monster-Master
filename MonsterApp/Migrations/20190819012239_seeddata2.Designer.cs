﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonsterApp.Context;

namespace MonsterApp.Migrations
{
    [DbContext(typeof(MonsterDBContext))]
    [Migration("20190819012239_seeddata2")]
    partial class seeddata2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MonsterApp.Context.Monster", b =>
                {
                    b.Property<int>("MonsterId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Attack");

                    b.Property<int>("Defense");

                    b.Property<int>("Health");

                    b.Property<int>("Level");

                    b.Property<int?>("MonsterTypeId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("MonsterId");

                    b.HasIndex("MonsterTypeId");

                    b.ToTable("Monsters");

                    b.HasData(
                        new { MonsterId = 1, Attack = 0, Defense = 0, Health = 5, Level = 1, Name = "Bulbasaur" },
                        new { MonsterId = 2, Attack = 0, Defense = 0, Health = 5, Level = 1, Name = "Pichu" }
                    );
                });

            modelBuilder.Entity("MonsterApp.Context.MonsterType", b =>
                {
                    b.Property<int>("MonsterTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("MonsterTypeId");

                    b.ToTable("MonsterTypes");

                    b.HasData(
                        new { MonsterTypeId = 1, TypeName = "Generation I" },
                        new { MonsterTypeId = 2, TypeName = "Generation II" },
                        new { MonsterTypeId = 3, TypeName = "Generation III" },
                        new { MonsterTypeId = 4, TypeName = "Generation IV" }
                    );
                });

            modelBuilder.Entity("MonsterApp.Context.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAccountCreated");

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("Gold");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int?>("UserTypeId");

                    b.HasKey("UserId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Users");

                    b.HasData(
                        new { UserId = 1, DateAccountCreated = new DateTime(2019, 8, 18, 21, 22, 39, 217, DateTimeKind.Local), EmailAddress = "ambremandar@gmail.com", FirstName = "Mandar", Gold = 1, LastName = "Ambre", Password = "test123" },
                        new { UserId = 2, DateAccountCreated = new DateTime(2019, 8, 18, 21, 22, 39, 218, DateTimeKind.Local), EmailAddress = "steve.rossiter@ancoraeducation.com", FirstName = "Steve", Gold = 1, LastName = "Rossiter", Password = "test123" }
                    );
                });

            modelBuilder.Entity("MonsterApp.Context.UserType", b =>
                {
                    b.Property<int>("UserTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("UserTypeId");

                    b.ToTable("UserTypes");

                    b.HasData(
                        new { UserTypeId = 1, TypeName = "Admin" },
                        new { UserTypeId = 2, TypeName = "User" }
                    );
                });

            modelBuilder.Entity("MonsterApp.Context.Monster", b =>
                {
                    b.HasOne("MonsterApp.Context.MonsterType", "MonsterType")
                        .WithMany()
                        .HasForeignKey("MonsterTypeId");
                });

            modelBuilder.Entity("MonsterApp.Context.User", b =>
                {
                    b.HasOne("MonsterApp.Context.UserType", "UserType")
                        .WithMany()
                        .HasForeignKey("UserTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}