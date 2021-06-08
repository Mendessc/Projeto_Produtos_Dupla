using System;
using System.Collections.Generic;
using Projeto_Produtos_Dupla.Interfaces;

namespace Projeto_Produtos_Dupla.Classes
{
    public class Usuario : IUsuario
    {
        private int Codigo { get; set; }


        private string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }



        List<Usuario> ListaUsuario = new List<Usuario>();

        public Usuario()
        {
            
        }

        public Usuario(int _Codigo, string _Nome, string _Email, string _Senha)
        {
            Codigo = _Codigo;
            Nome = _Nome;
            Email = _Email;
            Senha = _Senha;
        }

        public string Cadastrar(Usuario usuarios)
        {
    
            ListaUsuario.Add(usuarios);
            return $"Usuario cadastrado com sucesso!{usuarios.ListaUsuario}";
        }

        public string Deletar(Usuario usuario)
        {
            ListaUsuario.Remove(usuario);
            return "Usuario removido com sucesso!";
        }
    }
}