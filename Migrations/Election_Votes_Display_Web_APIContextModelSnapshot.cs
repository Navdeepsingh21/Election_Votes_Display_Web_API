﻿// <auto-generated />
using Election_Votes_Display_Web_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Election_Votes_Display_Web_API.Migrations
{
    [DbContext(typeof(Election_Votes_Display_Web_APIContext))]
    partial class Election_Votes_Display_Web_APIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Election_Votes_Display_Web_API.Business.CandidateVote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Candidate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfVotes")
                        .HasColumnType("int");

                    b.Property<string>("Party")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CandidateVote");
                });
#pragma warning restore 612, 618
        }
    }
}
