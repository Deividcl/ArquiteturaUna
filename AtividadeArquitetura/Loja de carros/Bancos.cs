using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeArquitetura.Loja_de_carros
{
    public class Bancos
    {
        private double _Preco;
        private string _Modelo;
        private string _Fabricante;

        public double Preco { get => _Preco; set => _Preco = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public string Fabricante { get => _Fabricante; set => _Fabricante = value; }

        public Bancos(double Preco, string Modelo, string Fabricante)
        {
            this.Preco = Preco;
            this.Modelo = Modelo;
            this.Fabricante = Fabricante;
        }
    }
}
