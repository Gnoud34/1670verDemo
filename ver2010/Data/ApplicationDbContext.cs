using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ver2010.Models;

namespace ver2010.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ver2010.Models.Application> Application { get; set; }
        public DbSet<ver2010.Models.Category> Category { get; set; }
        public DbSet<ver2010.Models.User> User { get; set; }
        public DbSet<ver2010.Models.JobPost> JobPost { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JobPost>()
                .HasOne(jp => jp.Category)
                .WithMany(c => c.JobPosts)
                .HasForeignKey(jp => jp.CategoryId);

            modelBuilder.Entity<Application>()
                .HasOne(a => a.JobPost)
                .WithMany(jp => jp.Applications)
                .HasForeignKey(a => a.JobPostId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Application>()
                .HasOne(a => a.User)
                .WithMany(u => u.Applications)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict); 

            SeedUserRole(modelBuilder);
        }


        private void CreateUserIdTrigger()
        {
            var sql = @"
            CREATE TRIGGER trg_BeforeInsertUser
            ON AspNetUsers -- Adjust the table name if necessary
            INSTEAD OF INSERT
            AS
            BEGIN
                INSERT INTO AspNetUsers (Id, FullName, Age, Gender, Email, Address, PhoneNumber, Skill, Image)
                SELECT 
                    CAST(NEWID() AS NVARCHAR(450)), -- Generate a new ID
                    FullName, 
                    Age, 
                    Gender, 
                    Email, 
                    Address, 
                    PhoneNumber, 
                    Skill, 
                    Image
                FROM inserted;
            END;";

            this.Database.ExecuteSqlRaw(sql);
        }

        private void SeedUserRole(ModelBuilder modelBuilder)
        {
            var empAccount = new IdentityUser
            {
                Id = "user1",
                UserName = "emp@gmail.com",
                Email = "emp@gmail.com",
                NormalizedUserName = "EMP@GMAIL.COM",
                NormalizedEmail = "EMP@GMAIL.COM",
                EmailConfirmed = true,
            };

            var userAccount = new IdentityUser
            {
                Id = "user2",
                UserName = "user@gmail.com",
                Email = "user@gmail.com",
                NormalizedUserName = "USER@GMAIL.COM",
                NormalizedEmail = "USER@GMAIL.COM",
                EmailConfirmed = true,
            };

            var hasher = new PasswordHasher<IdentityUser>();
            empAccount.PasswordHash = hasher.HashPassword(empAccount, "123456");
            userAccount.PasswordHash = hasher.HashPassword(userAccount, "123456");

            modelBuilder.Entity<IdentityUser>().HasData(empAccount, userAccount);

            // Seed roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "role1",
                    Name = "Employer",
                    NormalizedName = "EMPLOYER",
                },
                new IdentityRole
                {
                    Id = "role2",
                    Name = "User",
                    NormalizedName = "USER",
                }
            );

            // Assign roles to users
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "user1",
                    RoleId = "role1",
                },
                new IdentityUserRole<string>
                {
                    UserId = "user2",
                    RoleId = "role2",
                }
            );

            modelBuilder.Entity<User>().HasData(
        new User
        {
            Id = "user1",
            UserId = "user1",
            FullName = "Employer",
            Age = 30,
            Gender = "Other",
            Email = "emp@gmail.com",
            Address = "123 User St",
            PhoneNumber = "0123456789",
            Skill = "General",
            Image = "default.png"
        }
    );

            modelBuilder.Entity<User>().HasData(
        new User
        {
            Id = "user2", 
            UserId = "user2",
            FullName = "User Two",
            Age = 30,
            Gender = "Other",
            Email = "user@gmail.com",
            Address = "123 User St",
            PhoneNumber = "0123456789",
            Skill = "General",
            Image = "default.png"
        }
    );
        }
    }
}
