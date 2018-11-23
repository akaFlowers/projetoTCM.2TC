using projetoCuboMagico.domínio;
using projetoCuboMagico.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCuboMagico.controlador
{
    class ControladorTelaLogin
    {
        private TextBox txtUsuario;
        private TextBox txtSenha;


        //Construtores

        public ControladorTelaLogin()
        {

        }

        public ControladorTelaLogin(TextBox txtUsuario, TextBox txtSenha)
        {
            this.TxtUsuario = txtUsuario;
            this.TxtSenha = txtSenha;
        }

        //Getters And Setters

        public TextBox TxtUsuario { get => txtUsuario; set => txtUsuario = value; }
        public TextBox TxtSenha { get => txtSenha; set => txtSenha = value; }


        //Instancias
        Usuario usuario = new Usuario();
        RepositorioUsuario repositorioUsuario = new RepositorioUsuario();

        //Codigo

        public void InicializarObjetos()
        {
            usuario._usuario = txtUsuario.Text;
            usuario._senha = txtSenha.Text;
        }

        public bool Login()
        {
            InicializarObjetos();
            return repositorioUsuario.AutenticarUsuario(usuario);
        }
    }
}
