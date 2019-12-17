namespace EstoqueEntityModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Criacao_do_Banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProdutoEstoques",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    NumeroProduto = c.String(nullable: false),
                    NomeProduto = c.String(nullable: false),
                    DescricaoProduto = c.String(),
                    EstoqueProduto = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.ProdutoEstoques");
        }
    }
}
