using System;
using System.Collections.Generic;
using Projeto_Produtos.Interfaces;

namespace Projeto_Produtos.Classes
{
    public class Marca : IMarca
    {
        private int Codigo { get; set; }
        private string NomeMarca { get; set; }
        private DateTime DataCadastro { get; set; }

        List<Marca> ListaMarcas = new List<Marca>();

        public Marca()
        {

        }
        public Marca(string _nomeMarca)
        {
            NomeMarca = _nomeMarca;
            DataCadastro = DateTime.Now;
        }

        public string Cadastrar(Marca marca)
        {
            ListaMarcas.Add(marca);
            return "Marca cadastrada com sucesso!";
        }


        public string Deletar(Marca marca)
        {
            ListaMarcas.Remove(marca);
            return "Marca removida com sucesso!";
        }

        public List<Marca> Listar()
        {
            return ListaMarcas;
        }
    }
}