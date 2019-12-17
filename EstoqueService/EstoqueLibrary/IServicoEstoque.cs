using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EstoqueLibrary
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/01", Name = "IServicoEstoque")]
    public interface IServicoEstoque
    {

        [OperationContract]
        List<string> ListarProdutos();

        [OperationContract]
        bool IncluirProduto(Produto produto);

        [OperationContract]
        bool RemoverProduto(string NumeroProduto);

        [OperationContract]
        int ConsultarEstoque(string NumeroProduto);

        [OperationContract]
        bool AdicionarEstoque(string NumeroProduto, int Quantidade);

        [OperationContract]
        bool RemoverEstoque(string NumeroProduto, int Quantidade);

        [OperationContract]
        Produto VerProduto(string NumeroProduto);

        // TODO: Adicione suas operações de serviço aqui
    }

    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/02", Name = "IServicoEstoqueV2")]
    public interface IServicoEstoqueV2
    {
        [OperationContract]
        bool AdicionarEstoque(string NumeroProduto, int Quantidade);

        [OperationContract]
        bool RemoverEstoque(string NumeroProduto, int Quantidade);

        [OperationContract]
        int ConsultarEstoque(string NumeroProduto);
    }

    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
    [DataContract]
    public class Produto
    {
        [DataMember]
        private string NumeroProduto;

        [DataMember]
        private string NomeProduto;

        [DataMember]
        private string DescricaoProduto;

        [DataMember]
        private int EstoqueProduto;

        public string getNumeroProduto()
        {
            return this.NumeroProduto;
        }

        public void setNumeroProduto(string NumeroProduto)
        {
            this.NumeroProduto = NumeroProduto;
        }

        public string getNomeProduto()
        {
            return this.NomeProduto;
        }

        public void setNomeProduto(string NomeProduto)
        {
            this.NomeProduto = NomeProduto;
        }

        public string getDescricaoProduto()
        {
            return this.DescricaoProduto;
        }

        public void setDescricaoProduto(string DescricaoProduto)
        {
            this.DescricaoProduto = DescricaoProduto;
        }

        public int getEstoqueProduto()
        {
            return this.EstoqueProduto;
        }

        public void setEstoqueProduto(int EstoqueProduto)
        {
            this.EstoqueProduto = EstoqueProduto;
        }
    }
}
