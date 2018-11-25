using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeaveRequest.ASP.Common.Interface;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.Controllers
{
    public class RMController : Controller
    {
        private readonly IEmployeeLeaveService _employeeLeaveService;
        public RMController() { }
        public RMController(IEmployeeLeaveService employeeLeaveService)
        {
            this._employeeLeaveService = employeeLeaveService;
        }
        // GET: RM
        public ActionResult Index()
        {
            if (Session["Id"] != null)
            {
                var d = _employeeLeaveService.GetHiList();
                IEnumerable<EmployeeLeaveParam2> list_employeeleave = d.Select(c => new EmployeeLeaveParam2
                {
                    Id = c.Id,
                    Name = c.Employees.Name,
                    LeaveDays = c.LeaveDays,
                    Note = c.Note,
                    CreateDate = c.CreateDate,
                    ApprovalStatus = c.ApprovalStatus
                });
                return View(list_employeeleave);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        [HttpPost]
        public ActionResult EditRjct(EmployeeLeaveParam2 employeeLeaveParam2)
        {
            if (ModelState.IsValid)
            {
                _employeeLeaveService.UpdateRMRejected(employeeLeaveParam2);
                return RedirectToAction("Index");
            }
            return View(employeeLeaveParam2);
        }

        [HttpPost]
        public ActionResult EditAppr(EmployeeLeaveParam2 employeeLeaveParam2)
        {
            if (ModelState.IsValid)
            {
                _employeeLeaveService.UpdateRMApproved(employeeLeaveParam2);
                return RedirectToAction("Index");
            }
            return View(employeeLeaveParam2);
        }
    }
}