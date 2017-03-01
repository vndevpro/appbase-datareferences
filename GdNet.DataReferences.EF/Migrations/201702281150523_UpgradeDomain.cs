namespace GdNet.DataReferences.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UpgradeDomain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReferenceItems", "Position", c => c.Int(nullable: true));
            AddColumn("dbo.ReferenceLists", "Position", c => c.Int(nullable: true));
        }

        public override void Down()
        {
            DropColumn("dbo.ReferenceLists", "Position");
            DropColumn("dbo.ReferenceItems", "Position");
        }
    }
}
