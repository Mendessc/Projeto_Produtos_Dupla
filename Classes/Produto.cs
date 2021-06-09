using System;
using System.Collections.Generic;
using Projeto_Produtos.Interfaces;
using Projeto_Produtos_Dupla.Classes;

namespace Projeto_Produtos.Classes
{
    public class Produto : IProduto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public string NomeMarca { get; set; }
        public string NomeUsuario { get; set; }
        
                
        public DateTime DataCadastro { get; set; }
        public float Preco { get; set; }
        public Marca marca { get; set; }
        public Usuario usuarios { get; set; }
        public List<Produto> ListaDeProdutos { get; set; }
        List<Produto> ListaProdutos = new List<Produto>();
        public Produto()
        {

        }
        public Produto(int _codigo, string _nomeProduto, float _preco, string _NomeMarca, string _NomeUsuario)
        {
            this.Codigo = _codigo;
            this.NomeProduto = _nomeProduto;
            this.Preco = _preco;
            this.DataCadastro = DateTime.Now;
            this.NomeMarca = _NomeMarca;
            this.NomeUsuario = _NomeUsuario;
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

        public string Deletar(Produto produto, int index)
        {
            ListaProdutos.RemoveAt(index);
            return "Produto removido com sucesso!";
        }

        
    }
}

