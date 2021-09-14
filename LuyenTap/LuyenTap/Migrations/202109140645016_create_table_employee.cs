namespace LuyenTap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_employee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128, unicode: false),
                        Company = c.String(),
                        Address = c.String(),
                        PersonName = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
