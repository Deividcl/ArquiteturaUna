using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeArquitetura.Loja_de_carros
{
    public class Carro
    {
        private Pneus _Pneus;
        private Motor _Motor;
        private Bancos _Bancos;

        public Pneus Pneus { get => _Pneus; set => _Pneus = value; }
        public Motor Motor { get => _Motor; set => _Motor = value; }
        public Bancos Bancos { get => _Bancos; set => _Bancos = value; }

        public Carro(Pneus pneus, Motor motor, Bancos bancos)
        {
            this.Pneus = pneus;
            this.Bancos = bancos;
            this.Motor = motor;
        }

        public double ValorCarro()
        {
            return Pneus.Preco + Motor.Preco + Bancos.Preco;
        }

        public void ChamarCarro()
        {

            Pneus pneusUm = new Pneus(10.00, "Tipo A", "Toyota");
            Pneus pneusDois = new Pneus(20.00, "Tipo B", "Renault");

            Motor motorUm = new Motor(50.00, 100, "Toyota");
            Motor motorDois = new Motor(100.00, 200, "Renault");

            Bancos bancosUm = new Bancos(100.00, "Modelo A", "Toyota");
            Bancos bancosDois = new Bancos(10.00, "Modelo B", "Renault");

            Carro carroUm = new Carro(pneusUm, motorUm, bancosUm);
            Carro carroDois = new Carro(pneusDois, motorDois, bancosDois);

            Console.WriteLine("Carro 1");
            Console.Write(carroUm.ValorCarro());

            Console.WriteLine("");

            Console.WriteLine("Carro 2");
            Console.Write(carroDois.ValorCarro());
            Console.ReadKey();

        }
    }


}
