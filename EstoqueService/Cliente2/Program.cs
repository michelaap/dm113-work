using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using Cliente2.ServicoEstoque;

namespace Cliente2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER when the Client 2 has started");
            Console.ReadLine();

            ServicoEstoqueV2Client proxy = new ServicoEstoqueV2Client("WS2007HttpBinding_IServicoEstoque");

            Console.WriteLine("Testes Cliente 2");

            Console.WriteLine();
            Console.WriteLine("1) Verificar o estoque atual do Produto 1");

            int estoqueProduto1 = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Estoque atual do Produto 1: {0}", estoqueProduto1);

            Console.WriteLine();
            Console.WriteLine("2) Adicionar 20 unidades para este produto");

            bool addEstoqueProduto1 = proxy.AdicionarEstoque("1000", 20);
            if (addEstoqueProduto1)
            {
                Console.WriteLine("20 unidades adiconadas ao estoque do Produto 1");
            }
            else
            {
                Console.WriteLine("Erro ao adiconar estoque!");
            }

            Console.WriteLine();
            Console.WriteLine("3) Verificar o estoque do Produto 1 novamente");

            estoqueProduto1 = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Estoque atual do Produto 1: {0}", estoqueProduto1);

            Console.WriteLine();
            Console.WriteLine("4) Verificar o estoque do Produto 5");

            int estoqueProduto5 = proxy.ConsultarEstoque("5000");
            Console.WriteLine("Estoque atual do Produto 5: {0}", estoqueProduto5);

            Console.WriteLine();
            Console.WriteLine("5) Remover 10 unidades para este produto");

            bool remove10 = proxy.RemoverEstoque("5000", 10);
            if (remove10)
            {
                Console.WriteLine("10 unidades removidas do Produto 5");
            }
            else
            {
                Console.WriteLine("Erro ao remover estoque!");
            }

            Console.WriteLine();
            Console.WriteLine("6) Verificar o estoque do Produto 5 novamente");

            estoqueProduto5 = proxy.ConsultarEstoque("5000");
            Console.WriteLine("Estoque atual do Produto 5: {0}", estoqueProduto5);

            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
