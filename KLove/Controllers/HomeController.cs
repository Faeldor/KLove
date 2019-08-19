using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using KLove.Models;

namespace KLove.Controllers
{
	public class HomeController : Controller
	{
		IRepository<Department> DepartmentRepository { get; }
		IRepository<Employee> EmployeeRepository { get; }

		public HomeController(IRepository<Department> departmentRepository, IRepository<Employee> employeeRepository)
		{
			DepartmentRepository = departmentRepository;
			EmployeeRepository = employeeRepository;
		}

		public IActionResult Index()
		{
			var indexData = new IndexModel
			{
				Departments = DepartmentRepository.Get().ToList(),
				Employees = EmployeeRepository.Get().ToList()
			};

			return View(indexData);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
