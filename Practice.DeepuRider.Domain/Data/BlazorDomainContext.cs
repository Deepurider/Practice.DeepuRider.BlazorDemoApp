
using Microsoft.EntityFrameworkCore;
using Practice.DeepuRider.Domain.Data.Configurations;
using Practice.DeepuRider.Domain.Models;
using System;
using System.Collections.Generic;
namespace Practice.DeepuRider.Domain.Data;

public partial class BlazorDomainContext : DbContext
{
    public BlazorDomainContext()
    {
    }

    public BlazorDomainContext(DbContextOptions<BlazorDomainContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Configurations.UserConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
