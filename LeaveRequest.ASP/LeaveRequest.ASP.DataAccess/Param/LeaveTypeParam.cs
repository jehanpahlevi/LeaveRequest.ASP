using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Models;

namespace LeaveRequest.ASP.DataAccess.Param
{
    public class LeaveTypeParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalDays { get; set; }

        public LeaveTypeParam() { }
        public LeaveTypeParam(LeaveType leavetype)
        {
            this.Id = leavetype.Id;
            this.Name = leavetype.Name;
            this.TotalDays = leavetype.TotalDays;
        }
    }
}
