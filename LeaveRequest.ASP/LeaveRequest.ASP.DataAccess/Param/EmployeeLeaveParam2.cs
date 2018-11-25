using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Models;

namespace LeaveRequest.ASP.DataAccess.Param
{
    public class EmployeeLeaveParam2
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public string LeaveType { get; set; }
        public int? LeaveDays { get; set; }
        public string Backup { get; set; }
        public string Note { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public string ApprovalStatus { get; set; }
        public int? ThisYearBefore { get; set; }
        public int? LastYearBefore { get; set; }
        public int? ThisYearAfter { get; set; }
        public int? LastYearAfter { get; set; }

        public EmployeeLeaveParam2() { }
        public EmployeeLeaveParam2(EmployeeLeave employeeLeave)
        {
            this.Id = employeeLeave.Id;
            this.ApprovalStatus = employeeLeave.ApprovalStatus;
        }
    }
}
