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
            Console.WriteLine("Digite o código do produto");
            marca.Codigo = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o nome do produto");
            marca.NomeMarca = Console.ReadLine();

            ListaMarcas.Add(marca);
            return "Marca cadastrada com sucesso!";
        }

        public List<Marca> Listar()
        {
            return ListaMarcas;
        }

        public string Deletar(Marca marca)
        {
            ListaMarcas.RemoveAll(x => x.NomeMarca == marca.NomeMarca);
            return "Marca removida com sucesso!";
        }

    }
}