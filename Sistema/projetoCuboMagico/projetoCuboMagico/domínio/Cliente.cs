using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCuboMagico.domínio
{
    class Cliente
    {
        private int codigo;
        private string nome;
        private string sexo;
        private string dataNascimento;
        private string estadoCivil;
        private string cpf;
        private string email;
        private string telefone;
        private string celular;
        private string cep;
        private string endereco;
        private string numero;
        private string estado;
        private string cidade;
        private string bairro;
        private string complemento;
        private string referencia;
        private string genero1;
        private string genero2;
        private string genero3;
        private string genero4;
        private string genero5;


        //Construtores

        public Cliente()
        {

        }

        public Cliente(int codigo, string nome, string sexo, string dataNascimento, string estadoCivil, string cpf, string email, string telefone, string celular, string cep, string endereco, string numero, string estado, string cidade, string bairro, string complemento, string referencia, string genero1, string genero2, string genero3, string genero4, string genero5)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.sexo = sexo;
            this.dataNascimento = dataNascimento;
            this.estadoCivil = estadoCivil;
            this.cpf = cpf;
            this.email = email;
            this.telefone = telefone;
            this.celular = celular;
            this.cep = cep;
            this.endereco = endereco;
            this.numero = numero;
            this.estado = estado;
            this.cidade = cidade;
            this.bairro = bairro;
            this.complemento = complemento;
            this.referencia = referencia;
            this.genero1 = genero1;
            this.genero2 = genero2;
            this.genero3 = genero3;
            this.genero4 = genero4;
            this.genero5 = genero5;
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

        public string _sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string _dataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public string _estadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        public string _cpf
        {
            get { return cpf; }
            set { cpf = value; }
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

        public string _celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string _cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string _endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string _numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string _estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string _cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string _bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string _complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string _referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

        public string _genero1
        {
            get { return genero1;  }
            set { genero1 = value; }

        }

        public string _genero2
        {
            get { return genero2; }
            set { genero2 = value; }

        }

        public string _genero3
        {
            get { return genero3; }
            set { genero3 = value; }

        }

        public string _genero4
        {
            get { return genero4; }
            set { genero4 = value; }

        }
        public string _genero5
        {
            get { return genero5; }
            set { genero5 = value; }

        }

        //Codigo

        public override string ToString()
        {
            return String.Concat("\nCodigo: " + _codigo,
                                "\nNome: " + _nome,
                                "\nSexo:  " + _sexo,
                                "\nNascimento :  " + _dataNascimento,
                                "\nEstado Civil: " + _estadoCivil,
                                "\nCPF: " + _cpf,
                                "\nE-Mail: " + _email,
                                "\nTelefone: " + _telefone,
                                "\nCelular: " + _celular,
                                "\nCEP: " + _cep,
                                "\nEndereco: " + _endereco + ", " + _numero,
                                "\nEstado: " + _estado,
                                "\nCidade: " + _cidade,
                                "\nBairro: " + _bairro,
                                "\nComplemento: " + _complemento,
                                "\nReferência: " + _referencia,
                                "\nGenero 1: " + genero1,
                                "\nGenero 2: " + genero2,
                                "\nGenero 3: " + genero3,
                                "\nGenero 4: " + genero4,
                                "\nGenero 5; " + genero5);
        }
    }
}
