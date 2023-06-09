﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Domain;

namespace TaskManagementSystem.Persistence;
public class TaskManagementDbContext : IdentityDbContext<ApplicationUser>
{
    public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options)
            : base(options)
    {
    }

    public DbSet<CheckList> CheckLists { get; set; }
    public DbSet<TaskEntity> TaskEntitys { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskManagementDbContext).Assembly);
    }
}
