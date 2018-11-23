using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCuboMagico.domínio
{
    class Livro
    {
       
         
        private int codigo;
        private string nome;
        private int quantidade;
        private string capa;
        private string sinopse;
        private decimal valor;
        private string autor;
        private int editora;
        private string genero;
        private string dataPublicacao;
        private int qtdPaginas;

        //Construtores
        public Livro()
        {
        }

        public Livro(int codigo, string nome, int quantidade, string capa, string sinopse, decimal valor, string autor, int editora, string genero, string dataPublicacao, int qtdPaginas)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.quantidade = quantidade;
            this.capa = capa;
            this.sinopse = sinopse;
            this.valor = valor;
            this.autor = autor;
            this.editora = editora;
            this.genero = genero;
            this.dataPublicacao = dataPublicacao;
            this.qtdPaginas = qtdPaginas;
        }

        public int _codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string _nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int _quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public string _capa
        {
            get { return capa; }
            set { capa = value; }
        }

        public string _sinopse
        {
            get { return sinopse; }
            set { sinopse = value; }
        }

        public decimal _valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string _autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int _editora
        {
            get { return editora; }
            set { editora = value; }
        }

        public string _genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string _dataPublicacao
        {
            get { return dataPublicacao; }
            set { dataPublicacao = value; }
        }

        public int _qtdPaginas
        {
            get { return qtdPaginas; }
            set { qtdPaginas = value; }
        }


        //Codigo

        public override string ToString()
        {
            return String.Concat("\nCodigo: " + _codigo.ToString(),
                                "\nNome: " + _nome,
                                "\nCapa: " + _capa,
                                "\nQtd Paginas; " + _qtdPaginas,
                                "\nSínopse: " + _sinopse,
                                "\nGênero: " + _genero,
                                "\nAutor: " + _autor,
                                "\nEditora: " + _editora,
                                "\nData Publicação: " + _dataPublicacao,
                                "\nQuantidade: " + _quantidade,
                                "\nValor: " + _valor);
        }
    }
}
