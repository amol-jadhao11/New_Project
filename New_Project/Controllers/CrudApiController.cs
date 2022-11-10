using New_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace New_Project.Controllers
{
    public class CrudApiController : ApiController
    {
        //DemoEntities1 db = new DemoEntities1();

        //[HttpGet]
        //public IHttpActionResult GetEmployees()
        //{
        //    List<Employee> List = db.EmployeeViewModel.ToList();
        //    return Ok(List);   // Get All Emp List
        //}

        //[HttpGet]
        //public IHttpActionResult GetEmployeesById(int? id)
        //{
        //    var emp = db.EmployeeViewModel.Where(model => model.EmpID == id).FirstOrDefault();
        //    return Ok(emp);   // Get Emp By Id
        //}

        //[HttpPost]
        //public IHttpActionResult Insert_Employees(Employee e)
        //{
        //    db.EmployeeViewModel.Add(e);
        //    db.SaveChanges();
        //    return Ok();
        //}

        //[HttpPut]
        //public IHttpActionResult UpDate_Employees(Employee e)
        //{
        //    db.Entry(e).State = System.Data.Entity.EntityState.Modified;
        //    db.SaveChanges();

        //    //var emp = db.Employees.Where(model => model.EmpID == e.EmpID).FirstOrDefault();
        //    //if (emp != null)
        //    //{
        //    //    emp.EmpID = e.EmpID;
        //    //    emp.EmpName = e.EmpName;
        //    //    emp.Designation = e.Designation;
        //    //    emp.Department = e.Department;
        //    //    emp.JoiningDate = e.JoiningDate;
        //    //    db.SaveChanges();

        //    //}
        //    //else
        //    //{
        //    //    return NotFound();
        //    //}
        //    return Ok();
        //}

        //[HttpDelete]
        //public IHttpActionResult Delete_Employees(int id)
        //{
        //    var emp = db.EmployeeViewModel.Where(model => model.EmpID == id).FirstOrDefault();
        //    db.Entry(emp).State = System.Data.Entity.EntityState.Deleted; 
        //    db.SaveChanges();
        //    return Ok();
        //}
    }
}
