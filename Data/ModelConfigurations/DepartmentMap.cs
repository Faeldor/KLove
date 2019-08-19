using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.ModelConfigurations
{
	public class DepartmentMap : IEntityTypeConfiguration<Department>
	{
		public void Configure(EntityTypeBuilder<Department> entity)
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("KLove_Department");

			entity.Property(e => e.Id)
				.ValueGeneratedOnAdd();

			entity.Property(e => e.Name);

			entity.Property(e => e.Active)
				.HasColumnName("Active")
				.IsUnicode(false);

			entity.Property(e => e.CreatedBy)
				.HasColumnName("CreatedBy")
				.IsRequired();

			entity.Property(e => e.Created)
				.HasColumnName("Created")
				.IsRequired();

			entity.Property(e => e.LastModifiedBy)
				.HasColumnName("LastModifiedBy")
				.IsRequired();

			entity.Property(e => e.LastModified)
				.HasColumnName("LastModified")
				.IsRequired();

			entity.HasMany(d => d.Employees)
				.WithOne(p => p.Department)
				.HasForeignKey(p => p.DepartmentId);
		}
	}
}