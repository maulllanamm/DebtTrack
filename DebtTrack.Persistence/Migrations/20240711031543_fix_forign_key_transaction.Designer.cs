﻿// <auto-generated />
using System;
using DebtTrack.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DebtTrack.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240711031543_fix_forign_key_transaction")]
    partial class fix_forign_key_transaction
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DebtTrack.Domain.Entities.Activity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("activity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("activity_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("bill")
                        .HasColumnType("double precision");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("system");

                    b.Property<DateTimeOffset?>("created_date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("debtor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool?>("is_deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("modified_by")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("system");

                    b.Property<DateTimeOffset?>("modified_date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("place")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("tax")
                        .HasColumnType("double precision");

                    b.Property<double>("total_bill")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("activities", (string)null);
                });

            modelBuilder.Entity("DebtTrack.Domain.Entities.Participant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("created_by")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("system");

                    b.Property<DateTimeOffset?>("created_date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("divisi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool?>("is_deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("modified_by")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("system");

                    b.Property<DateTimeOffset?>("modified_date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("nama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("panggilan")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("participants", (string)null);
                });

            modelBuilder.Entity("DebtTrack.Domain.Entities.Permission", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("http_method")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("permissions", (string)null);
                });

            modelBuilder.Entity("DebtTrack.Domain.Entities.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("roles", (string)null);
                });

            modelBuilder.Entity("DebtTrack.Domain.Entities.RolePermission", b =>
                {
                    b.Property<int>("role_id")
                        .HasColumnType("integer");

                    b.Property<int>("permission_id")
                        .HasColumnType("integer");

                    b.HasKey("role_id", "permission_id");

                    b.HasIndex("permission_id");

                    b.ToTable("role_permissions", (string)null);
                });

            modelBuilder.Entity("DebtTrack.Domain.Entities.Transaction", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("activity_id")
                        .HasColumnType("integer");

                    b.Property<decimal>("amount")
                        .HasColumnType("numeric");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("system");

                    b.Property<DateTimeOffset?>("created_date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool?>("is_deleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("is_paid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("modified_by")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("system");

                    b.Property<DateTimeOffset?>("modified_date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("participant_id")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("activity_id");

                    b.HasIndex("participant_id");

                    b.ToTable("transactions", (string)null);
                });

            modelBuilder.Entity("DebtTrack.Domain.Entities.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("system");

                    b.Property<DateTimeOffset?>("created_date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("full_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool?>("is_deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("modified_by")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("system");

                    b.Property<DateTimeOffset?>("modified_date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("password_hash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("password_reset_expires")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("password_reset_token")
                        .HasColumnType("text");

                    b.Property<string>("password_salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("refresh_token")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("refresh_token_created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("refresh_token_expires")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("role_id")
                        .HasColumnType("integer");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("verify_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("verify_token")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("role_id");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("DebtTrack.Domain.Entities.RolePermission", b =>
                {
                    b.HasOne("DebtTrack.Domain.Entities.Permission", "permission")
                        .WithMany("role_permissions")
                        .HasForeignKey("permission_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DebtTrack.Domain.Entities.Role", "role")
                        .WithMany("role_permissions")
                        .HasForeignKey("role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("permission");

                    b.Navigation("role");
                });

            modelBuilder.Entity("DebtTrack.Domain.Entities.Transaction", b =>
                {
                    b.HasOne("DebtTrack.Domain.Entities.Activity", null)
                        .WithMany()
                        .HasForeignKey("activity_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DebtTrack.Domain.Entities.Participant", null)
                        .WithMany()
                        .HasForeignKey("participant_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DebtTrack.Domain.Entities.User", b =>
                {
                    b.HasOne("DebtTrack.Domain.Entities.Role", "role")
                        .WithMany()
                        .HasForeignKey("role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");
                });

            modelBuilder.Entity("DebtTrack.Domain.Entities.Permission", b =>
                {
                    b.Navigation("role_permissions");
                });

            modelBuilder.Entity("DebtTrack.Domain.Entities.Role", b =>
                {
                    b.Navigation("role_permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
