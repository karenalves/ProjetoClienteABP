namespace ProjetoCliente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alter_cliente : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clientes", "Documento_Id", "dbo.Documentoes");
            DropIndex("dbo.Clientes", new[] { "Documento_Id" });
            DropColumn("dbo.Clientes", "DocumentoId");
            RenameColumn(table: "dbo.Clientes", name: "Documento_Id", newName: "DocumentoId");
            AlterColumn("dbo.Clientes", "DocumentoId", c => c.Long(nullable: false));
            AlterColumn("dbo.Clientes", "DocumentoId", c => c.Long(nullable: false));
            CreateIndex("dbo.Clientes", "DocumentoId");
            AddForeignKey("dbo.Clientes", "DocumentoId", "dbo.Documentoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "DocumentoId", "dbo.Documentoes");
            DropIndex("dbo.Clientes", new[] { "DocumentoId" });
            AlterColumn("dbo.Clientes", "DocumentoId", c => c.Long());
            AlterColumn("dbo.Clientes", "DocumentoId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Clientes", name: "DocumentoId", newName: "Documento_Id");
            AddColumn("dbo.Clientes", "DocumentoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clientes", "Documento_Id");
            AddForeignKey("dbo.Clientes", "Documento_Id", "dbo.Documentoes", "Id");
        }
    }
}
