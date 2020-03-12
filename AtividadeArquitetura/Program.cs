using AtividadeArquitetura.Loja_de_carros;
using System;

namespace AtividadeArquitetura
{
    class Program
    {
        static void Main(string[] args)
        {            
            Pedido pedido = new Pedido(1, "Pedro", "Azul"); 
            pedido.ChamarPedido();
            Cliente cliente = new Cliente(2);
            cliente.ChamarCliente();
            Pneus pneu = new Pneus(10, "novos", "Eu mesmo");
            Carro carro = new Carro(
                new Pneus( 10.00, "",  ""),
                new Motor (20.00, 500, "A shined"),
                new Bancos ( 10.00, "", "A shined")
            );
            carro.ChamarCarro();
        }     
              
    }
}
