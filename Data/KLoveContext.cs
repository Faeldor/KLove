using System;
using System.Collections.Generic;
using System.Text;
using Data.ModelConfigurations;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
	public class KLoveContext : DbContext
	{
		public KLoveContext(DbContextOptions<KLoveContext> options) : base(options)
		{
			Database.SetCommandTimeout(500);
		}

		public virtual DbSet<Department> Department { get; set; }
		public virtual DbSet<Employee> Employee { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new DepartmentMap());
			modelBuilder.ApplyConfiguration(new EmployeeMap());
		}
	}
}
