using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.DataAccess.Models
{
    public class LeaveType : BaseModel
    {
        public string Name { get; set; }
        public int TotalDays { get; set; }
        public LeaveType() { }
        public LeaveType(LeaveTypeParam leavetypeparam)
        {
            this.Name = leavetypeparam.Name;
            this.TotalDays = leavetypeparam.TotalDays;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Update(LeaveTypeParam leavetypeparam)
        {
            this.Id = leavetypeparam.Id;
            this.Name = leavetypeparam.Name;
            this.TotalDays = leavetypeparam.TotalDays;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
