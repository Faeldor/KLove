using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KLove.Controllers
{
    public class EmployeeController : Controller
	{
		IRepository<Department> DepartmentRepository { get; }
		IRepository<Employee> EmployeeRepository { get; }

		public EmployeeController(IRepository<Department> departmentRepository, IRepository<Employee> employeeRepository)
		{
			DepartmentRepository = departmentRepository;
			EmployeeRepository = employeeRepository;
		}

		public IActionResult Edit(int? employeeId = null)
        {
			var data = new Employee();

			if (employeeId != null)
			{
				data = EmployeeRepository.Get(x => x.Id == employeeId).FirstOrDefault();
			}

			var departments = DepartmentRepository.Get().ToList();

			var selectList = new List<SelectListItem>
			{
				new SelectListItem("None", null)
			};

			foreach (var item in departments)
			{
				selectList.Add(new SelectListItem(item.Name, item.Id.ToString()));
			}

			ViewBag.Departments = new SelectList(selectList, "Value", "Text", 0);

            return View(data);
        }



        [HttpPost]
        public IActionResult Save(Employee employee)
        {

	        employee.LastModified = DateTime.Now;
	        employee.LastModifiedBy = "UserName";

	        if (employee.Id == 0)
	        {
		        employee.CreatedBy = "UserName";
		        employee.Created = DateTime.Now;

		        EmployeeRepository.Insert(employee);
	        }
	        else
	        {
		        EmployeeRepository.Update(employee);
	        }

	        return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int employeeId)
        {
	        var employee = EmployeeRepository.Get(x => x.Id == employeeId).FirstOrDefault();

	        if (employee != null)
	        {
		        EmployeeRepository.Remove(employee);
	        }

	        return RedirectToAction("Index", "Home");
        }
	}
}