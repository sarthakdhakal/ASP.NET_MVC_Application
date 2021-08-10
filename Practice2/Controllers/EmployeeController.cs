using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Practice2.Models;

namespace Practice2.Controllers
{
    public class EmployeeController : Controller
    {
         PracticeDbEntities1 _db = new PracticeDbEntities1();
        // GET
        public ActionResult Index()
        {
            List<Employee> empList = _db.Employees.ToList();
            List<EmployeeDataModel> employeeDataModels = empList.Select(x => new EmployeeDataModel()
            {
                Name = x.Name,
                Address = x.Address,
                EmployeeId = x.EmployeeId,
            
                DepartmentName = x.Department.DepartmentName
                
            }).ToList();
            return View(employeeDataModels);
        }

        public ActionResult Create()
        {
            throw new System.NotImplementedException();
        }

        public ActionResult EmployeeDetails()
        {
            throw new System.NotImplementedException();
        }
    
        public ActionResult AddEdit(int employeeId)
        {
            List<Department> departments = _db.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(departments, "DepartmentId", "DepartmentName");
            List<Site> sites = _db.Sites.ToList();
            ViewBag.SiteList = new SelectList(sites, "id", "name");
            EmployeeDataModel model = new EmployeeDataModel();
            if (employeeId > 0)
            {
                Employee employee = _db.Employees.SingleOrDefault(x => x.EmployeeId == employeeId);
                if (employee != null)
                {
                    model.Name = employee.Name;
                    model.EmployeeId = employee.EmployeeId;
                    model.Address = employee.Address;
                    
                }
            }
            
            return PartialView();  
        }
        [HttpPost]
        public ActionResult AddEdit(Employee employee)
        {   
            
            return View();
        }
    }
}