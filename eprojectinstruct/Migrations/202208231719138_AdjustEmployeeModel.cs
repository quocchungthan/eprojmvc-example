﻿namespace eprojectinstruct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustEmployeeModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Email");
        }
    }
}
