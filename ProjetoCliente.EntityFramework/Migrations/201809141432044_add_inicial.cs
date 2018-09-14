namespace ProjetoCliente.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class add_inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.String(),
                        DocumentoId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Documento_Id = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Cliente_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Documentoes", t => t.Documento_Id)
                .Index(t => t.Documento_Id);
            
            CreateTable(
                "dbo.Documentoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TipoDocumento = c.String(),
                        NumeroDocumento = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Documento_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        NomeProduto = c.String(),
                        PrazoEntrega = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Pedido_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Telefones",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        NumeroTelefone = c.Int(nullable: false),
                        TipoTelefone = c.String(),
                        ClienteId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Cliente_Id = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Telefone_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.ClientePedido",
                c => new
                    {
                        ClienteId = c.Long(nullable: false),
                        PedidoId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClienteId, t.PedidoId })
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Pedidoes", t => t.PedidoId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.PedidoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefones", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.ClientePedido", "PedidoId", "dbo.Pedidoes");
            DropForeignKey("dbo.ClientePedido", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "Documento_Id", "dbo.Documentoes");
            DropIndex("dbo.ClientePedido", new[] { "PedidoId" });
            DropIndex("dbo.ClientePedido", new[] { "ClienteId" });
            DropIndex("dbo.Telefones", new[] { "Cliente_Id" });
            DropIndex("dbo.Clientes", new[] { "Documento_Id" });
            DropTable("dbo.ClientePedido");
            DropTable("dbo.Telefones",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Telefone_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.Pedidoes",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Pedido_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.Documentoes",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Documento_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("dbo.Clientes",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Cliente_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
