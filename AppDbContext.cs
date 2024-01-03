﻿using A4WebApi.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace A4WebApi.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

       
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
