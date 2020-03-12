using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeArquitetura
{
    public class Cliente
    {

        private int _CodigoCliente;
        private string _NomeCompleto;

        public int CodigoCliente { get => _CodigoCliente; set => _CodigoCliente = value; }
        public string NomeCompleto { get => _NomeCompleto; set => _NomeCompleto = value; }

        public Cliente(int CodigoCliente)
        {
            this.CodigoCliente = CodigoCliente;
        }

        public void InsercaoNomeCliente(string nomeCliente)
        {
            NomeCompleto = nomeCliente;
        }

        public string RetornarNomeCliente()
        {
            return NomeCompleto;
        }

        public string RetornarCodigoCliente()
        {
            return CodigoCliente.ToString();
        }

        public void ChamarCliente()
        {
            Cliente clienteUm = new Cliente(1);
            Cliente clienteDois = new Cliente(2);

            Console.WriteLine("Cliente 1");
            Console.WriteLine(clienteUm.RetornarNomeCliente());
            clienteUm.InsercaoNomeCliente("Deivid César");
            Console.WriteLine(clienteUm.RetornarNomeCliente());

            Console.WriteLine("");

            Console.WriteLine("Cliente 2");
            Console.WriteLine(clienteDois.RetornarNomeCliente());
            clienteDois.InsercaoNomeCliente("Lemes Deivid");
            Console.WriteLine(clienteDois.RetornarNomeCliente());
            Console.WriteLine("");
            Console.WriteLine("");
        }

    }
}
