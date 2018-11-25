using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.Common.Interface;
using LeaveRequest.ASP.Common.Interface.Application;
using LeaveRequest.ASP.DataAccess.Models;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.BussinessLogic.Service
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        bool status = false;

        public AdminService() { }

        public AdminService(IAdminRepository adminRepository)
        {
            this._adminRepository = adminRepository;
        }

        public bool DeleteCom(int? id)
        {
            return _adminRepository.DeleteCom(id);
        }

        public bool DeleteDept(int? id)
        {
            return _adminRepository.DeleteDept(id);
        }

        public bool DeleteEmp(int? id)
        {
            return _adminRepository.DeleteEmp(id);
        }

        public bool DeleteLeave(int? id)
        {
            return _adminRepository.DeleteLeave(id);
        }

        public List<Company> GetCom()
        {
            return _adminRepository.GetCom();
        }

        public Company GetCom(int? id)
        {
            return _adminRepository.GetCom(id);
        }

        public List<Department> GetDept()
        {
            return _adminRepository.GetDept();
        }

        public Department GetDept(int? id)
        {
            return _adminRepository.GetDept(id);
        }

        public List<Employee> GetEmp()
        {
            return _adminRepository.GetEmp();
        }

        public Employee GetEmp(int? id)
        {
            return _adminRepository.GetEmp(id);
        }

        public List<LeaveType> GetLeave()
        {
            return _adminRepository.GetLeave();
        }

        public LeaveType GetLeave(int? id)
        {
            return _adminRepository.GetLeave(id);
        }

        public bool InsertCom(CompanyParam companyParam)
        {
            return _adminRepository.InsertCom(companyParam);
        }

        public bool InsertDept(DepartmentParam departmentParam)
        {
            return _adminRepository.InsertDept(departmentParam);
        }

        public bool InsertEmp(EmployeeParam employeeParam)
        {
            return _adminRepository.InsertEmp(employeeParam);
        }

        public bool InsertLeave(LeaveTypeParam leaveTypeParam)
        {
            return _adminRepository.InsertLeave(leaveTypeParam);
        }

        public bool UpdateCom(CompanyParam companyParam)
        {
            return _adminRepository.UpdateCom(companyParam);
        }

        public bool UpdateDept(DepartmentParam departmentParam)
        {
            return _adminRepository.UpdateDept(departmentParam);
        }

        public bool UpdateEmp(EmployeeParam employeeParam)
        {
            return _adminRepository.UpdateEmp(employeeParam);
        }

        public bool UpdateLeave(LeaveTypeParam leaveTypeParam)
        {
            return _adminRepository.UpdateLeave(leaveTypeParam);
        }
    }
}
