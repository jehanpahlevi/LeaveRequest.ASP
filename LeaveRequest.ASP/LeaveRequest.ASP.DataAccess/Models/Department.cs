using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.DataAccess.Models
{
    public class Department : BaseModel
    {
        public string Name { get; set; }
        public Company Companies { get; set; }
        public Department() { }
        public Department(DepartmentParam departmentparam)
        {
            this.Name = departmentparam.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
            this.CreatedBy = departmentparam.Id;
        }
        public virtual void Update(DepartmentParam departmentparam)
        {
            this.Id = departmentparam.Id;
            this.Name = departmentparam.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
            this.UpdatedBy = departmentparam.Id;
        }
        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }

    }
    
    
}
