using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace KLove.Controllers
{
    public class DepartmentController : Controller
    {
	    IRepository<Department> DepartmentRepository { get; }

	    public DepartmentController(IRepository<Department> departmentRepository)
	    {
		    DepartmentRepository = departmentRepository;
	    }

		public IActionResult Edit(int? departmentId = null)
		{
			var data = new Department();

			if (departmentId != null)
			{
				data = DepartmentRepository.Get(x => x.Id == departmentId, "Employees").FirstOrDefault();
			}

            return View(data);
        }

		[HttpPost]
		public IActionResult Save(Department department)
		{

			department.LastModified = DateTime.Now;
			department.LastModifiedBy = "UserName";

			if (department.Id == 0)
			{
				department.CreatedBy = "UserName";
				department.Created = DateTime.Now;

				DepartmentRepository.Insert(department);
			}
			else
			{
				DepartmentRepository.Update(department);
			}

			return RedirectToAction("Index", "Home");
		}
		
		public IActionResult Delete(int departmentId)
		{
			var department = DepartmentRepository.Get(x => x.Id == departmentId).FirstOrDefault();

			if (department != null)
			{
				DepartmentRepository.Remove(department);
			}

			return RedirectToAction("Index", "Home");
		}
	}
}