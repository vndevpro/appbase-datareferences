namespace GdNet.DataReferences.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialVersion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReferenceItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Value = c.String(),
                        LastModifiedAt = c.DateTime(),
                        LastModifiedBy = c.String(),
                        IsAvailable = c.Boolean(nullable: false),
                        State = c.String(),
                        StateLastChangedAt = c.DateTime(),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Note = c.String(),
                        ReferenceList_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ReferenceLists", t => t.ReferenceList_Id)
                .Index(t => t.ReferenceList_Id);
            
            CreateTable(
                "dbo.ReferenceLists",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        Manageable = c.Boolean(nullable: false),
                        LastModifiedAt = c.DateTime(),
                        LastModifiedBy = c.String(),
                        IsAvailable = c.Boolean(nullable: false),
                        State = c.String(),
                        StateLastChangedAt = c.DateTime(),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReferenceItems", "ReferenceList_Id", "dbo.ReferenceLists");
            DropIndex("dbo.ReferenceItems", new[] { "ReferenceList_Id" });
            DropTable("dbo.ReferenceLists");
            DropTable("dbo.ReferenceItems");
        }
    }
}
