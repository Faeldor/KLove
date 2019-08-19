using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
	public class Employee
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string StreetAddress { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public string ZipCode { get; set; }

		public string EmailAddress { get; set; }

		public string PhoneNumber { get; set; }

		public int DepartmentId { get; set; }

		public bool Active { get; set; }

		public string CreatedBy { get; set; }

		public DateTime Created { get; set; }

		public string LastModifiedBy { get; set; }

		public DateTime LastModified { get; set; }

		//Relationships
		public Department Department { get; set; }
	}
}
