namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        ParentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.ParentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Parents");
        }
    }
}
