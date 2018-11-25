namespace LeaveRequest.ASP.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModelEmpL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeLeaves", "StartDateSpecial", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.EmployeeLeaves", "EndDateSpecial", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.EmployeeLeaves", "DaysSpecial", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeLeaves", "DaysSpecial");
            DropColumn("dbo.EmployeeLeaves", "EndDateSpecial");
            DropColumn("dbo.EmployeeLeaves", "StartDateSpecial");
        }
    }
}
