using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.Common.Interface.Application;
using LeaveRequest.ASP.DataAccess.Context;
using LeaveRequest.ASP.DataAccess.Models;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.BussinessLogic.Repository
{
    public class EmployeeLeaveRepository : IEmployeeLeaveRepository
    {
        BaseContext _context = new BaseContext();
        bool status = false;
        
        public Employee Get(int? id)
        {
            if (id == null)
            {
                Console.Write("id is null");
            }
            Employee employee = _context.Employees.Include("Departments").Include("Departments.Companies").SingleOrDefault(x => x.Id == id);
            if (employee == null)
            {
                Console.Write("Employee Has not Value");
            }
            return employee;
        }
        
        public bool Insert(EmployeeLeaveParam employeeleaveparam)
        {
            var emp = _context.Employees.Find(employeeleaveparam.EmployeeId);
            var type = _context.LeaveTypes.Find(Convert.ToInt16(employeeleaveparam.LeaveType));
            var push = new EmployeeLeave(employeeleaveparam);
            push.ApprovalStatus = "Submited";
            push.Employees = emp;
            push.LeaveTypes = type;
            _context.EmployeeLeaves.Add(push);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public Employee GetDetails(EmployeeParam employeeparam)
        {
            if (employeeparam.Email == null && employeeparam.Password == null)
            {
                Console.Write("employee is null");
            }
            Employee employee = _context.Employees.SingleOrDefault(a=>a.Email==employeeparam.Email && a.Password==employeeparam.Password);
            if (employee == null)
            {
                Console.Write("Employee Has not Value");
            }
            return employee;
        }
        
        public LeaveType GetTypeLeave(int? id)
        {
            if (id == null)
            {
                Console.Write("id is null");
            }
            LeaveType leavetype = _context.LeaveTypes.SingleOrDefault(x => x.Id == id);
            if (leavetype == null)
            {
                Console.Write("Leave Type Has not Value");
            }
            return leavetype;
        }

        public List<LeaveType> LeaveType()
        {
            return _context.LeaveTypes.Where(x => x.IsDelete.Equals(false)).ToList();
        }



        public List<EmployeeLeave> GetHiList()
        {
            var k = _context.EmployeeLeaves.Include("Employees").Where(x => x.IsDelete.Equals(false)).ToList();
            return k;
        }

        public EmployeeLeave GetHi(int? id)
        {
            if (id == null)
            {
                Console.Write("Id is null");
            }
            EmployeeLeave employeeLeave = _context.EmployeeLeaves.SingleOrDefault(x => x.Id == id);
            if (employeeLeave == null)
            {
                Console.Write("EmployeeLeave has not value");
            }
            return employeeLeave;
        }

        public bool Update(EmployeeLeaveParam2 employeeLeaveParam2)
        {
            var getLeaveRequest = GetHi(employeeLeaveParam2.Id);
            getLeaveRequest.ApprovalStatus = "Cancelled";
            _context.Entry(getLeaveRequest).State = EntityState.Modified;
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateRMApproved(EmployeeLeaveParam2 employeeLeaveParam2)
        {
            var getLeaveRequest = GetHi(employeeLeaveParam2.Id);
            getLeaveRequest.ApprovalStatus = "Approved";
            _context.Entry(getLeaveRequest).State = EntityState.Modified;
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateRMRejected(EmployeeLeaveParam2 employeeLeaveParam2)
        {
            var getLeaveRequest = GetHi(employeeLeaveParam2.Id);
            getLeaveRequest.ApprovalStatus = "Rejected";
            _context.Entry(getLeaveRequest).State = EntityState.Modified;
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
