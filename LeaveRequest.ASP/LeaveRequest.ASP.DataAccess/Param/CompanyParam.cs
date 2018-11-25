using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Models;

namespace LeaveRequest.ASP.DataAccess.Param
{
    public class CompanyParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CompanyParam() { }
        public CompanyParam(Company company)
        {
            this.Id = company.Id;
            this.Name = company.Name;
        }
    }
}
