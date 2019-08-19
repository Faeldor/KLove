using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.ModelConfigurations
{
	public class EmployeeMap : IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> entity)
		{
			entity.HasKey(e => e.Id);

			entity.ToTable("KLove_Employee");

			entity.Property(e => e.Id)
				.ValueGeneratedOnAdd();

			entity.Property(e => e.FirstName);

			entity.Property(e => e.LastName);

			entity.Property(e => e.StreetAddress);

			entity.Property(e => e.City);

			entity.Property(e => e.State);

			entity.Property(e => e.ZipCode);

			entity.Property(e => e.EmailAddress);

			entity.Property(e => e.PhoneNumber);

			entity.Property(e => e.DepartmentId)
				.HasColumnName("KLove_DepartmentId")
				.IsRequired();

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
		}
	}
}
