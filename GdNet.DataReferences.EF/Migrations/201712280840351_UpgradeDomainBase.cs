namespace GdNet.DataReferences.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpgradeDomainBase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReferenceItems", "FriendlyId", c => c.String());
            AddColumn("dbo.ReferenceLists", "FriendlyId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReferenceLists", "FriendlyId");
            DropColumn("dbo.ReferenceItems", "FriendlyId");
        }
    }
}
