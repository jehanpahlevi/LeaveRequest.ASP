using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Models;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.Common.Interface.Application
{
    public interface IEmployeeLeaveRepository
    {
        Employee GetDetails(EmployeeParam employeeparam);
        Employee Get(int? id);
        LeaveType GetTypeLeave(int? id);
        List<LeaveType> LeaveType();
        bool Insert(EmployeeLeaveParam employeeleaveparam);

        List<EmployeeLeave> GetHiList();
        EmployeeLeave GetHi(int? id);
        bool Update(EmployeeLeaveParam2 employeeLeaveParam2);

        bool UpdateRMApproved(EmployeeLeaveParam2 employeeLeaveParam2);
        bool UpdateRMRejected(EmployeeLeaveParam2 employeeLeaveParam2);
    }
}
