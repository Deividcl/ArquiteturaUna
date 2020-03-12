using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeArquitetura.Loja_de_carros
{
    public class Motor
    {
        private double _Preco;
        private int _Potencia;
        private string _Fabricante;

        public double Preco { get => _Preco; set => _Preco = value; }
        public int Potencia { get => _Potencia; set => _Potencia = value; }
        public string Fabricante { get => _Fabricante; set => _Fabricante = value; }

        public Motor(double Preco, int Potencia, string Fabricante)
        {
            this.Preco = Preco;
            this.Potencia = Potencia;
            this.Fabricante = Fabricante;
        }
    }
}
