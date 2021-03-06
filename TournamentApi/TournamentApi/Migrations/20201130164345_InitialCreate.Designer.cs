﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TournamentApi.DataLayer;

namespace TournamentApi.Migrations
{
    [DbContext(typeof(TournamentDataContext))]
    [Migration("20201130164345_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TournamentApi.Model.Tournament", b =>
                {
                    b.Property<int>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("TournamentId");

                    b.ToTable("Tournaments");
                });
#pragma warning restore 612, 618
        }
    }
}
