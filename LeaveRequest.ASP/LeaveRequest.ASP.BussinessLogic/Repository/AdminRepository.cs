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
    public class AdminRepository : IAdminRepository
    {
        BaseContext _context = new BaseContext();
        bool status = false;

        public bool DeleteCom(int? id)
        {
            var getCompany = GetCom(id);
            getCompany.Delete();
            _context.Entry(getCompany).State = EntityState.Modified;
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool DeleteDept(int? id)
        {
            var getDepartment = GetDept(id);
            getDepartment.Delete();
            _context.Entry(getDepartment).State = EntityState.Modified;
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool DeleteEmp(int? id)
        {
            var getEmployee = GetEmp(id);
            getEmployee.Delete();
            _context.Entry(getEmployee).State = EntityState.Modified;
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool DeleteLeave(int? id)
        {
            var getLeaveType = GetLeave(id);
            getLeaveType.Delete();
            _context.Entry(getLeaveType).State = EntityState.Modified;
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Company> GetCom()
        {
            return _context.Companies.Where(x => x.IsDelete.Equals(false)).ToList();
        }

        public Company GetCom(int? id)
        {
            if (id == null)
            {
                Console.Write("Id is null");
            }
            Company company = _context.Companies.SingleOrDefault(x => x.Id == id);
            if (company == null)
            {
                Console.Write("Company has not value");
            }
            return company;
        }

        public List<Department> GetDept()
        {
            return _context.Departments.Include("Companies").Where(x => x.IsDelete.Equals(false)).ToList();
        }

        public Department GetDept(int? id)
        {
            if (id == null)
            {
                Console.Write("Id is null");
            }
            Department department = _context.Departments.Include("Companies").SingleOrDefault(x => x.Id == id);
            if (department == null)
            {
                Console.Write("Company has not value");
            }
            return department;
        }

        public List<Employee> GetEmp()
        {
            return _context.Employees.Include("Departments").Where(x => x.IsDelete.Equals(false)).ToList();
        }

        public Employee GetEmp(int? id)
        {
            if (id == null)
            {
                Console.Write("Id is null");
            }
            Employee employee = _context.Employees.Include("Departments").SingleOrDefault(x => x.Id == id);
            if (employee == null)
            {
                Console.Write("Company has not value");
            }
            return employee;
        }

        public List<LeaveType> GetLeave()
        {
            return _context.LeaveTypes.Where(x => x.IsDelete.Equals(false)).ToList();
        }

        public LeaveType GetLeave(int? id)
        {
            if (id == null)
            {
                Console.Write("Id is null");
            }
            LeaveType leaveType = _context.LeaveTypes.SingleOrDefault(x => x.Id == id);
            if (leaveType == null)
            {
                Console.Write("Company has not value");
            }
            return leaveType;
        }

        public bool InsertCom(CompanyParam companyParam)
        {
            var push = new Company(companyParam);
            _context.Companies.Add(push);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool InsertDept(DepartmentParam departmentParam)
        {
            var push = new Department(departmentParam);
            push.Companies = _context.Companies.Find(Convert.ToInt16(departmentParam.Companies));
            _context.Departments.Add(push);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool InsertEmp(EmployeeParam employeeParam)
        {
            var push = new Employee(employeeParam);
            push.Departments = _context.Departments.Find(Convert.ToInt16(employeeParam.Departments));
            _context.Employees.Add(push);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool InsertLeave(LeaveTypeParam leaveTypeParam)
        {
            var push = new LeaveType(leaveTypeParam);
            _context.LeaveTypes.Add(push);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateCom(CompanyParam companyParam)
        {
            var getCompany = GetCom(companyParam.Id);
            getCompany.Update(companyParam);
            _context.Entry(getCompany).State = EntityState.Modified;
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateDept(DepartmentParam departmentParam)
        {
            var getDepartment = GetDept(departmentParam.Id);
            getDepartment.Update(departmentParam);
            _context.Entry(getDepartment).State = EntityState.Modified;
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateEmp(EmployeeParam employeeParam)
        {
            var getEmployee = GetEmp(employeeParam.Id);
            getEmployee.Update(employeeParam);
            _context.Entry(getEmployee).State = EntityState.Modified;
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public bool UpdateLeave(LeaveTypeParam leaveTypeParam)
        {
            var getLeaveType = GetLeave(leaveTypeParam.Id);
            getLeaveType.Update(leaveTypeParam);
            _context.Entry(getLeaveType).State = EntityState.Modified;
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}
