using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.DataAccess.Models
{
    public class Employee : BaseModel
    {
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
        public Department Departments { get; set; }

        public Employee() { }
        public Employee(EmployeeParam employeeparam)
        {
            this.Name = employeeparam.Name;
            this.Email = employeeparam.Email;
            this.Phone = employeeparam.Phone;
            this.JoinDate = employeeparam.JoinDate;
            this.JobTitle = employeeparam.JobTitle;
            this.Status = employeeparam.Status;
            this.TotalChilds = employeeparam.TotalChilds;
            this.ThisYear = employeeparam.ThisYear;
            this.LastYear = employeeparam.LastYear;
            this.Password = employeeparam.Password;
            this.ManagerId = employeeparam.ManagerId;
            this.Departments.Name = employeeparam.Departments;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
            this.CreatedBy = employeeparam.Id;
        }
        public virtual void Update(EmployeeParam employeeparam)
        {
            this.Id = employeeparam.Id;
            this.Name = employeeparam.Name;
            this.Email = employeeparam.Email;
            this.Phone = employeeparam.Phone;
            this.JoinDate = employeeparam.JoinDate;
            this.JobTitle = employeeparam.JobTitle;
            this.Status = employeeparam.Status;
            this.TotalChilds = employeeparam.TotalChilds;
            this.ThisYear = employeeparam.ThisYear;
            this.LastYear = employeeparam.LastYear;
            this.Password = employeeparam.Password;
            this.ManagerId = employeeparam.ManagerId;
            this.Departments.Name = employeeparam.Departments;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
            this.UpdatedBy = employeeparam.Id;
        }
        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }

    }
}
