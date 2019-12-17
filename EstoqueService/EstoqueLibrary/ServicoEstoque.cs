using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using EstoqueEntityModel;
using System.ServiceModel.Activation;

namespace EstoqueLibrary
{
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicoEstoque : IServicoEstoque, IServicoEstoqueV2
    {
        public bool AdicionarEstoque(string NumeroProduto, int Quantidade)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    int produtoID = (
                        from pe in database.ProdutoEstoques
                        where String.Compare(pe.NumeroProduto, NumeroProduto) == 0
                        select pe.Id).First();

                    ProdutoEstoque produtoEstoque = database.ProdutoEstoques.First(pe => pe.Id == produtoID);
                    produtoEstoque.EstoqueProduto += Quantidade;
                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public int ConsultarEstoque(string NumeroProduto)
        {
            int Quantidade = 0;
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    int produtoID = (
                        from pe in database.ProdutoEstoques
                        where String.Compare(pe.NumeroProduto, NumeroProduto) == 0
                        select pe.Id).First();

                    ProdutoEstoque produtoEstoque = database.ProdutoEstoques.First(pe => pe.Id == produtoID);
                    Quantidade = produtoEstoque.EstoqueProduto;
                }
            }
            catch
            {

            }
            return Quantidade;
        }

        public bool IncluirProduto(Produto produto)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque produtoEstoque = new ProdutoEstoque();
                    produtoEstoque.NumeroProduto = produto.getNumeroProduto();
                    produtoEstoque.NomeProduto = produto.getNomeProduto();
                    produtoEstoque.DescricaoProduto = produto.getDescricaoProduto();
                    produtoEstoque.EstoqueProduto = produto.getEstoqueProduto();
                    database.ProdutoEstoques.Add(produtoEstoque);
                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public List<string> ListarProdutos()
        {
            List<string> produtos = new List<string>();
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    List<ProdutoEstoque> produtoEstoques = (from produto in database.ProdutoEstoques
                                                            select produto).ToList();

                    foreach (ProdutoEstoque produtoEstoque in produtoEstoques)
                    {
                        produtos.Add(produtoEstoque.NomeProduto);
                    }
                }
            }
            catch
            {

            }

            return produtos;
        }

        public bool RemoverEstoque(string NumeroProduto, int Quantidade)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    int produtoID = (
                        from pe in database.ProdutoEstoques
                        where String.Compare(pe.NumeroProduto, NumeroProduto) == 0
                        select pe.Id).First();

                    ProdutoEstoque produtoEstoque = database.ProdutoEstoques.First(pe => pe.Id == produtoID);
                    produtoEstoque.EstoqueProduto = produtoEstoque.EstoqueProduto - Quantidade;

                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool RemoverProduto(string NumeroProduto)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    int produtoID = (
                        from pe in database.ProdutoEstoques
                        where String.Compare(pe.NumeroProduto, NumeroProduto) == 0
                        select pe.Id).First();

                    ProdutoEstoque produtoEstoque = database.ProdutoEstoques.First(pe => pe.Id == produtoID);
                    database.ProdutoEstoques.Remove(produtoEstoque);

                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public Produto VerProduto(string NumeroProduto)
        {
            Produto produto = null;
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    int produtoID = (
                        from pe in database.ProdutoEstoques
                        where String.Compare(pe.NumeroProduto, NumeroProduto) == 0
                        select pe.Id).First();

                    ProdutoEstoque produtoEstoque = database.ProdutoEstoques.First(pe => pe.Id == produtoID);

                    produto = new Produto();
                    produto.setNumeroProduto(produtoEstoque.NumeroProduto);
                    produto.setNomeProduto(produtoEstoque.NomeProduto);
                    produto.setDescricaoProduto(produtoEstoque.DescricaoProduto);
                    produto.setEstoqueProduto(produtoEstoque.EstoqueProduto);
                }
            }
            catch
            {

            }
            return produto;
        }
    }
}
