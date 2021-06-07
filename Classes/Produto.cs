using System;
using System.Collections.Generic;
using Projeto_Produtos.Interfaces;

namespace Projeto_Produtos.Classes
{
    public class Produto : IProduto
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataCadastroP { get; set; }
        public float Preco { get; set; }
        public Marca marca { get; set; }
         List<Produto> ListaProdutos = new List<Produto>();

         public string Cadastrar(Produto produto)
        {
            ListaProdutos.Add(produto);
            return "Produto cadastrado com sucesso!";
        }

        public List<Produto> Listar()
        {
            return ListaProdutos;
        }

        public string Deletar(Produto produto)
        {
            ListaProdutos.Remove(produto);
            return "Produto removido com sucesso!";
        }

    }
}