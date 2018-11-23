
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCuboMagico.domínio
{
    class Produto
    {
        private int codigo;
        private string nome;
        private int quantidade;
        private string descricao;
        private decimal valor;


        //Construtores

        public Produto()
        {

        }

        public Produto(int codigo, string nome, int quantidade, string descricao, decimal valor)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.quantidade = quantidade;
            this.descricao = descricao;
            this.valor = valor;
        }

        //Codigo

        public int _codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int _quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public string _nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string _descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public decimal _valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public override string ToString()
        {
            return string.Concat("\nCodigo: " + _codigo,
                                 "\nNome: " + _nome,
                                 "\nDescrição: " + _descricao,
                                 "\nQuantidade: " + _quantidade,
                                 "\nValor Unitário: " + _valor
                );
        }


    }
}
