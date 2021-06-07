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
        
        
        
        List<Usuario> usuarios = new List<Usuario>();
        public string Cadastrar(Usuario usuario)
        {
            usuarios.Add(usuario);
            return "Usuario cadastrado com sucesso!";
        }

        public string Deletar(Usuario usuario)
        {
            usuarios.Remove(usuario);
            return "Usuario removido com sucesso!";
        }
    }
}