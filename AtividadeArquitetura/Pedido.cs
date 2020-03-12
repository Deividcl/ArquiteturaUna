using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeArquitetura
{
    public class Pedido
    {
        private int _CodigoPedido;
        private string _NomeCliente;
        private string _DescricaoPedido;

        public int CodigoPedido { get => _CodigoPedido; set => _CodigoPedido = value; }
        public string NomeCliente { get => _NomeCliente; set => _NomeCliente = value; }
        public string DescricaoPedido { get => _DescricaoPedido; set => _DescricaoPedido = value; }

        public Pedido(int CodigoPedido, string NomeCliente, string Descricao)
        {
            this.CodigoPedido = CodigoPedido;
            this.NomeCliente = NomeCliente;
            this.DescricaoPedido = Descricao;
        }

        public void ModificarNomeCliente(string novoNome)
        {
            NomeCliente = novoNome;
        }

        public void ModificarDescricaoPedido(string novaDescricao)
        {
            DescricaoPedido = novaDescricao;
        }

        public string RetornarDescricaoPedido()
        {
            return DescricaoPedido;
        }

        public string RetornarNomeCliente()
        {
            return NomeCliente;
        }

        public void ChamarPedido()
        {
            Pedido pedido1 = new Pedido(1, "Pedro", "Pedido Teste");
            Pedido pedido2 = new Pedido(2, "Mateus", "Pedido Teste Dois");

            Console.WriteLine("Cliente 1");
            Console.WriteLine(pedido1.NomeCliente);
            Console.WriteLine(pedido1.DescricaoPedido);
            pedido1.ModificarNomeCliente("Deivid César");
            pedido2.ModificarDescricaoPedido("Nova Descricao Teste");
            Console.WriteLine(pedido1.NomeCliente);
            Console.WriteLine(pedido1.DescricaoPedido);

            Console.WriteLine("");

            Console.WriteLine("Cliente 2");
            Console.WriteLine(pedido1.NomeCliente);
            Console.WriteLine(pedido1.DescricaoPedido);
            pedido1.ModificarNomeCliente("Lemes Deivid");
            pedido1.ModificarDescricaoPedido("Nova Descricao Teste Dois");
            Console.WriteLine(pedido1.NomeCliente);
            Console.WriteLine(pedido1.DescricaoPedido);
        }
    }
}
