using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCuboMagico.domínio
{
    class Editora
    {
        private int codigo;
        private string nome;
        private string email;
        private string telefone;
        private string cnpj;
        private string pais;

        //Construtroes
        public Editora()
        {

        }

        public Editora(int codigo, string nome, string email, string telefone, string cnpj, string pais)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.cnpj = cnpj;
            this.pais = pais;
        }

        //Getters And Setters

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

        public string _email
        {
            get { return email; }
            set { email = value; }
        }

        public string _telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string _cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string _pais
        {
            get { return pais; }
            set { pais = value; }
        }

        //Codigo

        public override string ToString()
        {
            return String.Concat("\nCodigo: " + _codigo,
                                "\nNome: " + _nome,
                                "\nCNPJ: " + _cnpj,
                                "\nTelefone: " + _telefone,
                                "\nEmail: " + _email,
                                "\nPaís: " + _pais);
        }
    }
}
