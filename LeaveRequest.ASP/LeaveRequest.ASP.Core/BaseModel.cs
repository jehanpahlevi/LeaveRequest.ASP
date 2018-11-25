using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequest.ASP.DataAccess.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public int DeletedBy { get; set; }
        public bool IsDelete { get; set; }
    }
}
