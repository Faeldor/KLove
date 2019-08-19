using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
	public class Department
	{
		public Department()
		{
			Employees = new HashSet<Employee>();
		}

		public int Id { get; set; }

		public string Name { get; set; }

		public bool Active { get; set; }

		public string CreatedBy { get; set; }

		public DateTime Created { get; set; }

		public string LastModifiedBy { get; set; }

		public DateTime LastModified { get; set; }

		//Relationships
		public ICollection<Employee> Employees { get; set; }
	}
}
