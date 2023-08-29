using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaMercado.Propriedades.DadosProdutos {
    internal class Produto {
        public String Nome { get; set; }

        public Decimal Valor { get; set; }

        public int QuantidadeEstoque { get; set; }
        public int Codigo { get; set; }

        public Produto() { }

        public Produto(string nome, decimal valor, int quantidadeEstoque, int codigo)
        {
            Nome = nome;
            Valor = valor;
            QuantidadeEstoque = quantidadeEstoque;
            Codigo = codigo;
        }
    }
}
