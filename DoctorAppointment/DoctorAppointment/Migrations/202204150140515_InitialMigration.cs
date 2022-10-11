namespace DoctorAppointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DoctorAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        role = c.String(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DId = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 25),
                        dept = c.String(nullable: false),
                        startTime = c.String(nullable: false),
                        endTime = c.String(nullable: false),
                        phone = c.String(nullable: false, maxLength: 10),
                        email = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.DId);
            
            CreateTable(
                "dbo.PatientAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PId = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 25),
                        gender = c.String(nullable: false),
                        phone = c.String(nullable: false, maxLength: 10),
                        email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
            DropTable("dbo.PatientAccounts");
            DropTable("dbo.Doctors");
            DropTable("dbo.DoctorAccounts");
        }
    }
}
