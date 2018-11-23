using projetoCuboMagico.persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCuboMagico.domínio
{
    class Funcionario
    {


        private int codigo;
        private string nome;
        private string sexo;
        private string dataNascimento;
        private string estado_civil;
        private string cpf;
        private string email;
        private string telefone;
        private string celular;
        private string cep;
        private string endereco;
        private string estado;
        private string cidade;
        private string bairro;
        private string numero;
        private string complemento;
        private string referencia;
        private string cargo;


        //Construtores

        public Funcionario()
        {

        }

        public Funcionario(int codigo, string nome, string sexo, string dataNascimento, string estado_civil, string cpf, string email, string telefone, string celular, string cep, string endereco, string estado, string cidade, string bairro, string numero, string complemento, string referencia, string cargo)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.sexo = sexo;
            this.dataNascimento = dataNascimento;
            this.estado_civil = estado_civil;
            this.cpf = cpf;
            this.email = email;
            this.telefone = telefone;
            this.celular = celular;
            this.cep = cep;
            this.endereco = endereco;
            this.estado = estado;
            this.cidade = cidade;
            this.bairro = bairro;
            this.numero = numero;
            this.complemento = complemento;
            this.referencia = referencia;
            this.cargo = cargo;
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
            get { return estado_civil; }
            set { estado_civil = value; }
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

        public string _numero
        {
            get { return numero; }
            set { numero = value; }
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

        public string _cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        //Codigo

        public override string ToString()
        {
            return String.Concat("\nCodigo: ",
                                "\nNome: " + _nome,
                                "\nSexo:  " + _sexo,
                                "\nNascimento :  " + _dataNascimento,
                                "\nEstado Civil" + _estadoCivil,
                                "\nCargo: " + _cargo,
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
                                "\nReferência: " + _referencia);

        }
    }
}
