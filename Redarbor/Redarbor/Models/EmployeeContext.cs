﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Redarbor.Models
{
    public class EmployeeContext: DbContext
    {

        public EmployeeContext(DbContextOptions<EmployeeContext> options): base(options) { }

        public DbSet<Employee> Employees { get; set; } = null;
    }
}
