namespace SDWard.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class poonam007 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Billing_table_Poonam",
                c => new
                    {
                        Bill_Id = c.Int(nullable: false, identity: true),
                        RecordId = c.Int(nullable: false),
                        MedicineName = c.String(),
                        AdmitDate = c.DateTime(),
                        DischargeDate = c.DateTime(),
                        TotalBill = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedBy = c.Int(),
                        ModifiedBy = c.Int(),
                        DeletedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Bill_Id)
                .ForeignKey("dbo.RecordSet_tbl_Poonam", t => t.RecordId, cascadeDelete: true)
                .Index(t => t.RecordId);
            
            CreateTable(
                "dbo.RecordSet_tbl_Poonam",
                c => new
                    {
                        RecordId = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        LName = c.String(),
                        RoomNo = c.Int(nullable: false),
                        DiseaseName = c.String(),
                        Description = c.String(),
                        AdmitDate = c.DateTime(),
                        DischargeDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedBy = c.Int(),
                        ModifiedBy = c.Int(),
                        DeletedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.RecordId);
            
            CreateTable(
                "dbo.Department_tbl_poonam",
                c => new
                    {
                        DeptId = c.Int(nullable: false, identity: true),
                        DeptName = c.String(),
                        Designation = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedBy = c.Int(),
                        ModifiedBy = c.Int(),
                        DeletedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.DeptId);
            
            CreateTable(
                "dbo.User_tbl_Poonam",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        FName = c.String(),
                        LName = c.String(),
                        Gender = c.String(),
                        Age = c.Int(nullable: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        Password = c.String(),
                        Contact = c.String(maxLength: 13, unicode: false),
                        DeptId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedBy = c.Int(),
                        ModifiedBy = c.Int(),
                        DeletedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Department_tbl_poonam", t => t.DeptId, cascadeDelete: true)
                .ForeignKey("dbo.UsersRole_tbl_poonam", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.Email, unique: true)
                .Index(t => t.Contact, unique: true)
                .Index(t => t.DeptId);
            
            CreateTable(
                "dbo.UsersRole_tbl_poonam",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserType = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedBy = c.Int(),
                        ModifiedBy = c.Int(),
                        DeletedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User_tbl_Poonam", "UserId", "dbo.UsersRole_tbl_poonam");
            DropForeignKey("dbo.User_tbl_Poonam", "DeptId", "dbo.Department_tbl_poonam");
            DropForeignKey("dbo.Billing_table_Poonam", "RecordId", "dbo.RecordSet_tbl_Poonam");
            DropIndex("dbo.User_tbl_Poonam", new[] { "DeptId" });
            DropIndex("dbo.User_tbl_Poonam", new[] { "Contact" });
            DropIndex("dbo.User_tbl_Poonam", new[] { "Email" });
            DropIndex("dbo.User_tbl_Poonam", new[] { "UserId" });
            DropIndex("dbo.Billing_table_Poonam", new[] { "RecordId" });
            DropTable("dbo.UsersRole_tbl_poonam");
            DropTable("dbo.User_tbl_Poonam");
            DropTable("dbo.Department_tbl_poonam");
            DropTable("dbo.RecordSet_tbl_Poonam");
            DropTable("dbo.Billing_table_Poonam");
        }
    }
}
