using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeaveRequest.ASP.Common.Interface;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        // GET: Company

        public AdminController() { }

        public AdminController(IAdminService adminService)
        {
            this._adminService = adminService;
        }


        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult IndexCompany()
        {
            if (Session["Id"] != null)
            {
                var d = _adminService.GetCom();
                IEnumerable<CompanyParam> list_company = d.Select(c => new CompanyParam
                {
                    Id = c.Id,
                    Name = c.Name
                });
                return View(list_company);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        public ActionResult CreateCompany(int? id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCompany(CompanyParam companyParam)
        {
            if (ModelState.IsValid)
            {
                _adminService.InsertCom(companyParam);
                return RedirectToAction("IndexCompany");
            }

            return View(companyParam);
        }

        public ActionResult EditCompany(int? id)
        {
            return View(new CompanyParam(_adminService.GetCom(id)));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCompany(CompanyParam companyParam)
        {
            if (ModelState.IsValid)
            {
                _adminService.UpdateCom(companyParam);
                return RedirectToAction("IndexCompany");
            }
            return View(companyParam);
        }

        [HttpPost]
        public ActionResult DeleteCompany(int? id)
        {
            _adminService.DeleteCom(id);
            return RedirectToAction("IndexCompany");
        }


        //=======================LeaveType=======================//


        public ActionResult IndexLeave()
        {
            if (Session["Id"] != null)
            {
                var d = _adminService.GetLeave();
                IEnumerable<LeaveTypeParam> list_leavetype = d.Select(c => new LeaveTypeParam
                {
                    Id = c.Id,
                    Name = c.Name,
                    TotalDays = c.TotalDays
                });
                return View(list_leavetype);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        public ActionResult CreateLeave(int? id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateLeave(LeaveTypeParam leaveTypeParam)
        {
            if (ModelState.IsValid)
            {
                _adminService.InsertLeave(leaveTypeParam);
                return RedirectToAction("IndexLeave");
            }

            return View(leaveTypeParam);
        }

        public ActionResult EditLeave(int? id)
        {
            return View(new LeaveTypeParam(_adminService.GetLeave(id)));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditLeave(LeaveTypeParam leaveTypeParam)
        {
            if (ModelState.IsValid)
            {
                _adminService.UpdateLeave(leaveTypeParam);
                return RedirectToAction("IndexLeave");
            }
            return View(leaveTypeParam);
        }

        [HttpPost]
        public ActionResult DeleteLeave(int? id)
        {
            _adminService.DeleteLeave(id);
            return RedirectToAction("IndexLeave");
        }


        //=======================LeaveType=======================//


        public ActionResult IndexDepartment()
        {
            if (Session["Id"] != null)
            {
                var d = _adminService.GetDept();
                IEnumerable<DepartmentParam> list_dept = d.Select(c => new DepartmentParam
                {
                    Id = c.Id,
                    Name = c.Name,
                    Companies = c.Companies.Name
                });
                return View(list_dept);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        public ActionResult CreateDepartment()
        {
            IEnumerable<SelectListItem> xList = _adminService.GetCom().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name.ToString()
            });
            ViewBag.Preview = xList;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDepartment(DepartmentParam departmentParam)
        {
            if (ModelState.IsValid)
            {

                _adminService.InsertDept(departmentParam);
                return RedirectToAction("IndexDepartment");
            }

            return View(departmentParam);
        }

        public ActionResult EditDepartment(int? id)
        {
            return View(new LeaveTypeParam(_adminService.GetLeave(id)));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDepartment(LeaveTypeParam leaveTypeParam)
        {
            if (ModelState.IsValid)
            {
                _adminService.UpdateLeave(leaveTypeParam);
                return RedirectToAction("IndexDepartment");
            }
            return View(leaveTypeParam);
        }

        [HttpPost]
        public ActionResult DeleteDepartment(int? id)
        {
            _adminService.DeleteDept(id);
            return RedirectToAction("IndexDepartment");
        }


        //=======================Employee=======================//


        public ActionResult IndexEmployee()
        {
            if (Session["Id"] != null)
            {
                var d = _adminService.GetEmp();
                IEnumerable<EmployeeParam> list_emp = d.Select(c => new EmployeeParam
                {
                    Id = c.Id,
                    Name = c.Name,
                    Email = c.Email,
                    Phone = c.Phone,
                    JoinDate = c.JoinDate,
                    JobTitle = c.JobTitle,
                    Status = c.Status,
                    TotalChilds = c.TotalChilds,
                    ThisYear = c.ThisYear,
                    LastYear = c.LastYear,
                    Departments = c.Departments.Name,
                    ManagerId = c.ManagerId
                });
                return View(list_emp);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        [HttpPost]
        public ActionResult DeleteEmployee(int? id)
        {
            _adminService.DeleteEmp(id);
            return RedirectToAction("IndexEmployee");
        }

        public ActionResult CreateEmployee()
        {
            IEnumerable<SelectListItem> xList = _adminService.GetDept().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            ViewBag.Preview = xList;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEmployee(EmployeeParam employeeParam)
        {
            if (ModelState.IsValid)
            {
                _adminService.InsertEmp(employeeParam);
                return RedirectToAction("IndexEmployee");
            }

            return View(employeeParam);
        }
    }
}