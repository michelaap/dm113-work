using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using Cliente.ServicoEstoque;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER when the service 1 has started");
            Console.ReadLine();

            ServicoEstoqueClient proxy = new ServicoEstoqueClient("BasicHttpBinding_IServicoEstoque");

            Console.WriteLine("Testes Cliente 1");

            Console.WriteLine();
            Console.WriteLine("1) Adicionar um produto");

            Produto produto = new Produto
            {
                NumeroProduto = "11000",
                NomeProduto = "Produto 11",
                DescricaoProduto = "Este é o produto 11",
                EstoqueProduto = 400
            };

            bool incluirProduto = proxy.IncluirProduto(produto);

            if (incluirProduto)
            {
                Console.WriteLine("Produto incluído!");
            }
            else
            {
                Console.WriteLine("Erro ao incluir o Produto :(");
            }

            Console.WriteLine();
            Console.WriteLine("2) Remover o produto 10");

            bool removerProduto10 = proxy.RemoverProduto("10000");
            if (removerProduto10)
            {
                Console.WriteLine("Produto 10 removido!");
            }
            else
            {
                Console.WriteLine("Erro ao remover o Produto 10");
            }

            Console.WriteLine();
            Console.WriteLine("3) Listar todos os produtos");

            List<string> produtos = proxy.ListarProdutos().ToList();
            foreach (string NomeProduto in produtos)
            {
                Console.WriteLine(NomeProduto);
            }

            Console.WriteLine();
            Console.WriteLine("4) Verificar todas as informações do Produto 2");

            produto = proxy.VerProduto("2000");
            Console.WriteLine("Numero do Produto: {0}", produto.NumeroProduto);
            Console.WriteLine("Nome do Produto: {0}", produto.NomeProduto);
            Console.WriteLine("Descricao do Produto: {0}", produto.DescricaoProduto);
            Console.WriteLine("Estoque do Produto: {0}", produto.EstoqueProduto);

            Console.WriteLine();
            Console.WriteLine("5) Adicionar 10 unidades para este produto");

            bool addEstoqueProduto2 = proxy.AdicionarEstoque("2000", 10);
            if (addEstoqueProduto2)
            {
                Console.WriteLine("10 unidades adiconadas ao estoque do Produto 2");
            }
            else
            {
                Console.WriteLine("Erro ao adiconar estoque!");
            }

            Console.WriteLine();
            Console.WriteLine("6) Verificar o estoque do Produto 2");

            int estoqueProduto2 = proxy.ConsultarEstoque("2000");
            Console.WriteLine("Estoque do Produto 2: {0}", estoqueProduto2);

            Console.WriteLine();
            Console.WriteLine("7) Verificar o estoque atual do Produto 1");

            int estoqueProduto1 = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Estoque atual do Produto 1: {0}", estoqueProduto1);

            Console.WriteLine();
            Console.WriteLine("8) Remover 20 unidades para este produto");

            bool remove20 = proxy.RemoverEstoque("1000", 20);
            if (remove20)
            {
                Console.WriteLine("20 unidades removidas do Produto 1");
            }
            else
            {
                Console.WriteLine("Erro ao remover estoque!");
            }

            Console.WriteLine();
            Console.WriteLine("9) Verificar o estoque do Produto 1 novamente");

            estoqueProduto1 = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Estoque atual do Produto 1: {0}", estoqueProduto1);

            Console.WriteLine();
            Console.WriteLine("10) Verificar todas as informações do Produto 1");

            produto = proxy.VerProduto("1000");
            Console.WriteLine("Numero do Produto: {0}", produto.NumeroProduto);
            Console.WriteLine("Nome do Produto: {0}", produto.NomeProduto);
            Console.WriteLine("Descricao do Produto: {0}", produto.DescricaoProduto);
            Console.WriteLine("Estoque do Produto: {0}", produto.EstoqueProduto);
            Console.WriteLine();

            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
