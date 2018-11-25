using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Models;

namespace LeaveRequest.ASP.DataAccess.Param
{
    public class DepartmentParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Companies { get; set; }
        public DepartmentParam() { }
        public DepartmentParam(Department department)
        {
            this.Id = department.Id;
            this.Name = department.Name;
            this.Companies = department.Companies.Name;
        }
    }
}
