using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using EstoqueLibrary;

namespace ProvedorEstoqueHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost servicoEstoqueHost = new ServiceHost(typeof(ServicoEstoque));
            servicoEstoqueHost.Open();
            Console.WriteLine("Service Running");

            Console.ReadLine();
            Console.WriteLine("Service Stopping");
            servicoEstoqueHost.Close();
        }
    }
}
