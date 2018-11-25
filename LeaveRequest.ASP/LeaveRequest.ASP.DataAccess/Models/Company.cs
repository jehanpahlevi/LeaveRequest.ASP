using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.DataAccess.Models
{
    public class Company : BaseModel
    {
        public string Name { get; set; }
        public Company() { }
        public Company(CompanyParam companyparam)
        {
            this.Name = companyparam.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
            this.CreatedBy = companyparam.Id;
        }
        public virtual void Update(CompanyParam companyparam)
        {
            this.Id = companyparam.Id;
            this.Name = companyparam.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
            this.UpdatedBy = companyparam.Id;
        }
        
        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
