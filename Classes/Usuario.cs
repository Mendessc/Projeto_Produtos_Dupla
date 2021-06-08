using System;
using System.Collections.Generic;
using Projeto_Produtos_Dupla.Interfaces;

namespace Projeto_Produtos_Dupla.Classes
{
    public class Usuario : IUsuario
    {
        private int Codigo { get; set; }


        private string Nome { get; set; }
        public string EmailU { get; set; }
        public string SenhaU { get; set; }



        List<Usuario> ListaUsuario = new List<Usuario>();

        public Usuario()
        {
            
        }

        public Usuario(int _Codigo, string _Nome, string _Email, string _Senha)
        {
            this.Codigo = _Codigo;
            this.Nome = _Nome;
            this.EmailU = _Email;
            this.SenhaU = _Senha;
        }

        public string Cadastrar(Usuario usuario)
        {
            ListaUsuario.Add(usuario);
            return usuario.EmailU;
        }

        public string Deletar(Usuario usuario)
        {
            ListaUsuario.Remove(usuario);
            return "Usuario removido com sucesso!";
        }

        public string RetornoEmail()
        {
            return EmailU;
        }
    }
}