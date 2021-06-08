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

        public string Cadastrar(Marca novaMarca)
        {
            Console.WriteLine("Digite o código do produto");
            novaMarca.Codigo = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o nome do produto");
            novaMarca.NomeMarca = Console.ReadLine();

            ListaMarcas.Add(novaMarca);
            return "Marca cadastrada com sucesso!";
        }

        public List<Marca> Listar()
        {
            return ListaMarcas;
        }

        public string Deletar(Marca novaMarca)
        {
            ListaMarcas.Remove(novaMarca);
            return "Marca removida com sucesso!";
        }

    }
}