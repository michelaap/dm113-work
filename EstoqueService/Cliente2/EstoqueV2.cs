﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente2.ServicoEstoque
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/02", ConfigurationName="Cliente2.ServicoEstoque.IServicoEstoqueV2")]
    public interface IServicoEstoqueV2
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoqueResponse")]
        bool RemoverEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoEstoqueV2Channel : Cliente2.ServicoEstoque.IServicoEstoqueV2, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoEstoqueV2Client : System.ServiceModel.ClientBase<Cliente2.ServicoEstoque.IServicoEstoqueV2>, Cliente2.ServicoEstoque.IServicoEstoqueV2
    {
        
        public ServicoEstoqueV2Client()
        {
        }
        
        public ServicoEstoqueV2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ServicoEstoqueV2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ServicoEstoqueV2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ServicoEstoqueV2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public bool AdicionarEstoque(string NumeroProduto, int Quantidade)
        {
            return base.Channel.AdicionarEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int Quantidade)
        {
            return base.Channel.AdicionarEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public bool RemoverEstoque(string NumeroProduto, int Quantidade)
        {
            return base.Channel.RemoverEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade)
        {
            return base.Channel.RemoverEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public int ConsultarEstoque(string NumeroProduto)
        {
            return base.Channel.ConsultarEstoque(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto)
        {
            return base.Channel.ConsultarEstoqueAsync(NumeroProduto);
        }
    }
}
