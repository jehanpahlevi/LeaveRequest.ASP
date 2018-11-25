using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Models;

namespace LeaveRequest.ASP.DataAccess.Param
{
    public class EmployeeParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateTimeOffset JoinDate { get; set; }
        public string JobTitle { get; set; }
        public string Status { get; set; }
        public int TotalChilds { get; set; }
        public int ThisYear { get; set; }
        public int LastYear { get; set; }
        public string Password { get; set; }
        public int ManagerId { get; set; }
        public string Departments { get; set; }
        public string Companies { get; set; }
        public EmployeeParam() { }
        public EmployeeParam(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Email = employee.Email;
            this.Phone = employee.Phone;
            this.JoinDate = employee.JoinDate;
            this.JobTitle = employee.JobTitle;
            this.Status = employee.Status;
            this.TotalChilds = employee.TotalChilds;
            this.ThisYear = employee.ThisYear;
            this.LastYear = employee.LastYear;
            this.Password = employee.Password;
            this.ManagerId = employee.ManagerId;
            this.Departments = employee.Departments.Name;
        }
    }
}
