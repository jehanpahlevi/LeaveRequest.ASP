namespace LeaveRequest.ASP.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelEmployeeLEave : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeLeaves", "DeductDays", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeLeaves", "DeductDays");
        }
    }
}
