using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCuboMagico.domínio
{
    class Usuario
    {
        private int codigo;
        public static int codFun { get; set; }
        private string usuario;
        private string senha;

        //Construtores

        public Usuario()
        {

        }

        public Usuario(int codigo, string usuario, string senha)
        {
            this.codigo = codigo;
            this.usuario = usuario;
            this.senha = senha;
        }

        //Getters And Setters
        public int _codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string _usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string _senha
        {
            get { return senha; }
            set { senha = value; }
        }


    }
}
