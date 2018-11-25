using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Models;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.Common.Interface.Application
{
    public interface IAdminRepository
    {
        List<Company> GetCom();
        Company GetCom(int? id);
        bool InsertCom(CompanyParam companyParam);
        bool UpdateCom(CompanyParam companyParam);
        bool DeleteCom(int? id);

        List<LeaveType> GetLeave();
        LeaveType GetLeave(int? id);
        bool InsertLeave(LeaveTypeParam leaveTypeParam);
        bool UpdateLeave(LeaveTypeParam leaveTypeParam);
        bool DeleteLeave(int? id);

        List<Department> GetDept();
        Department GetDept(int? id);
        bool InsertDept(DepartmentParam departmentParam);
        bool UpdateDept(DepartmentParam departmentParam);
        bool DeleteDept(int? id);

        List<Employee> GetEmp();
        Employee GetEmp(int? id);
        bool InsertEmp(EmployeeParam employeeParam);
        bool UpdateEmp(EmployeeParam employeeParam);
        bool DeleteEmp(int? id);
    }
}
