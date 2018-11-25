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
    public class EmployeeLeaveService : IEmployeeLeaveService
    {
        private readonly IEmployeeLeaveRepository _employeeLeaveRepository;
        public EmployeeLeaveService() { }
        public EmployeeLeaveService(IEmployeeLeaveRepository employeeLeaveRepository)
        {
            this._employeeLeaveRepository = employeeLeaveRepository;
        }
        public Employee Get(int? id)
        {
            return _employeeLeaveRepository.Get(id); 
        }

        public Employee GetDetails(EmployeeParam employeeparam)
        {
            return _employeeLeaveRepository.GetDetails(employeeparam);
        }

        public EmployeeLeave GetHi(int? id)
        {
            return _employeeLeaveRepository.GetHi(id);
        }

        public List<EmployeeLeave> GetHiList()
        {
            return _employeeLeaveRepository.GetHiList();
        }

        public LeaveType GetTypeLeave(int? id)
        {
            return _employeeLeaveRepository.GetTypeLeave(id);
        }

        public bool Insert(EmployeeLeaveParam employeeleaveparam)
        {
            return _employeeLeaveRepository.Insert(employeeleaveparam);
        }

        public List<LeaveType> LeaveType()
        {
            return _employeeLeaveRepository.LeaveType();
        }

        public bool Update(EmployeeLeaveParam2 employeeLeaveParam2)
        {
            return _employeeLeaveRepository.Update(employeeLeaveParam2);
        }

        public bool UpdateRMApproved(EmployeeLeaveParam2 employeeLeaveParam2)
        {
            return _employeeLeaveRepository.UpdateRMApproved(employeeLeaveParam2);
        }

        public bool UpdateRMRejected(EmployeeLeaveParam2 employeeLeaveParam2)
        {
            return _employeeLeaveRepository.UpdateRMRejected(employeeLeaveParam2);
        }
    }
}
