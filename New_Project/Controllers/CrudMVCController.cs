using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using New_Project.Models;
using New_Project.ViewModel;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace New_Project.Controllers
{
    public class CrudMVCController : Controller
    {
       
        // GET: CrudMVC
        HttpClient Client = new HttpClient();

        private DemoEntities1 demoEntities;

        public CrudMVCController()
        {
            demoEntities = new DemoEntities1();
        }

        public ActionResult Index()
        {
            return View();
        }
       
        public JsonResult GetAllEmp([DataSourceRequest] DataSourceRequest request)
        {

            var employee = demoEntities.Employees.ToList();

            return Json(employee.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);

            //IEnumerable<EmployeeViewModel> List_of_Emp =
            //     (from objemp in demoEntities.EmployeeViewModel
            //      select new EmployeeViewModel()
            //      {
            //          EmpID = objemp.EmpID,
            //          EmpName = objemp.EmpName,
            //          Designation = objemp.Designation,
            //          Department = objemp.Department,
            //          JoiningDate = objemp.JoiningDate,
            //      }).ToList();
            //return Json(List_of_Emp.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }


        // UPDATE: Employee  

        public ActionResult UpdateEmployee([DataSourceRequest] DataSourceRequest request, Employee emp)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    demoEntities.Entry(emp).State = EntityState.Modified;
                    demoEntities.SaveChanges();
                    return Json(new[] { emp }.ToDataSourceResult(request));

                }
                else
                {
                    return Json(demoEntities.Employees.ToList());
                }
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        // ADD: Employee  

        public ActionResult AddEmployee([DataSourceRequest] DataSourceRequest request, Employee emp)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    demoEntities.Employees.Add(emp);
                    demoEntities.SaveChanges();
                    var _emplist = demoEntities.Employees.ToList();
                    return Json(new[] { emp }.ToDataSourceResult(request));
                }

                else
                {
                    return Json(demoEntities.Employees.ToList());
                }
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        // DELETE: Employee  

        public ActionResult DeleteEmployee([DataSourceRequest] DataSourceRequest request, Employee emp)
        {
            try
            {
                Employee employee = demoEntities.Employees.Find(emp.EmpID);
                if (employee == null)
                {
                    return Json("Employee Not Found");
                }

                demoEntities.Employees.Remove(employee);
                demoEntities.SaveChanges();
                return Json(demoEntities.Employees.ToList());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
    }
}