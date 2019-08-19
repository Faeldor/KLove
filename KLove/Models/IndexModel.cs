using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;

namespace KLove.Models
{
	public class IndexModel
	{
		public List<Department> Departments { get; set; }
		public List<Employee> Employees { get; set; }
	}
}
