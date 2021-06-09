using System;
using System.Collections.Generic;
using Projeto_Produtos.Interfaces;
using Projeto_Produtos_Dupla.Classes;

namespace Projeto_Produtos.Classes
{
    public class Produto : IProduto
    {
        private int Codigo { get; set; }
        private string NomeProduto { get; set; }
        private DateTime DataCadastro { get; set; }
        private float Preco { get; set; }
        private Marca marca { get; set; }
        private Usuario usuarios { get; set; }
        private List<Produto> ListaDeProdutos { get; set; }
        List<Produto> ListaProdutos = new List<Produto>();
        public Produto()
        {

        }
        public Produto(int _codigo, string _nomeProduto, float _preco, Marca _marca, Usuario _usuarios)
        {
            this.Codigo = _codigo;
            this.NomeProduto = _nomeProduto;
            this.Preco = _preco;
            this.DataCadastro = DateTime.Now;
            this.marca = _marca;
            this.usuarios = _usuarios;
            this.ListaDeProdutos = ListaProdutos;
        }
        public string Cadastrar(Produto produto)
        {
            ListaProdutos.Add(produto);
            return "Produto adicionado com sucesso!";
        }

        public List<Produto> Listar()
        {
            return ListaProdutos;
        }

        public string Deletar(Produto produto)
        {
            ListaProdutos.RemoveAll(x => x.NomeProduto == produto.NomeProduto);
            return "Produto removido com sucesso!";
        }
    }
}

