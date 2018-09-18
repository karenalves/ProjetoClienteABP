namespace ProjetoCliente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ater_tipos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Telefones", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.Telefones", new[] { "Cliente_Id" });
            DropColumn("dbo.Telefones", "ClienteId");
            RenameColumn(table: "dbo.Telefones", name: "Cliente_Id", newName: "ClienteId");
            AlterColumn("dbo.Telefones", "ClienteId", c => c.Long(nullable: false));
            AlterColumn("dbo.Telefones", "ClienteId", c => c.Long(nullable: false));
            CreateIndex("dbo.Telefones", "ClienteId");
            AddForeignKey("dbo.Telefones", "ClienteId", "dbo.Clientes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefones", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Telefones", new[] { "ClienteId" });
            AlterColumn("dbo.Telefones", "ClienteId", c => c.Long());
            AlterColumn("dbo.Telefones", "ClienteId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Telefones", name: "ClienteId", newName: "Cliente_Id");
            AddColumn("dbo.Telefones", "ClienteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Telefones", "Cliente_Id");
            AddForeignKey("dbo.Telefones", "Cliente_Id", "dbo.Clientes", "Id");
        }
    }
}
