﻿using DebtTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DebtTrack.Persistence.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Konfigurasi nama tabel
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Role>().ToTable("roles");
            modelBuilder.Entity<Permission>().ToTable("permissions");
            modelBuilder.Entity<RolePermission>().ToTable("role_permissions");
            modelBuilder.Entity<Participant>().ToTable("participants");
            modelBuilder.Entity<Activity>().ToTable("activities");
            modelBuilder.Entity<Transaction>().ToTable("transactions");

            modelBuilder.Entity<RolePermission>()
            .HasKey(rp => new { rp.role_id, rp.permission_id });

            modelBuilder.Entity<Role>()
            .HasMany(r => r.role_permissions)
            .WithOne(rp => rp.role)
            .HasForeignKey(rp => rp.role_id);

            modelBuilder.Entity<Permission>()
                .HasMany(p => p.role_permissions)
                .WithOne(rp => rp.permission)
                .HasForeignKey(rp => rp.permission_id);
            
            modelBuilder.Entity<Transaction>()
                .Property("is_paid")
                .HasDefaultValue(false);
            
            modelBuilder.Entity<Transaction>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(d => d.debtor_id);
            
            modelBuilder.Entity<Transaction>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(d => d.creditor_id);
            
            
            // Daftar entitas yang ingin dikonfigurasi
            var entities = new[] { typeof(User), typeof(Transaction), typeof(Participant), typeof(Activity)};
            foreach (var entity in entities)
            {
                modelBuilder.Entity(entity)
                    .Property("created_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                modelBuilder.Entity(entity)
                    .Property("created_by")
                    .HasDefaultValue("system");

                modelBuilder.Entity(entity)
                    .Property("modified_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                modelBuilder.Entity(entity)
                    .Property("modified_by")
                    .HasDefaultValue("system");
            }


            base.OnModelCreating(modelBuilder);

        }


    }
}
