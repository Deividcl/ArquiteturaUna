using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeArquitetura.Loja_de_carros
{
    public class Pneus
    {
        private double _Preco;
        private string _Tipo;
        private string _Fabricante;

        public double Preco { get => _Preco; set => _Preco = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Fabricante { get => _Fabricante; set => _Fabricante = value; }

    

        public Pneus(double Preco, string Tipo, string Fabricante)
        {
            this.Preco = Preco;
            this.Tipo = Tipo;
            this.Fabricante = Fabricante;
        }
    }
}
