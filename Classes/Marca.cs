using System;
using System.Collections.Generic;
using Projeto_Produtos.Interfaces;

namespace Projeto_Produtos.Classes
{
    public class Marca : IMarca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<Marca> ListaMarcas = new List<Marca>();

        public Marca()
        {

        }
        public Marca(string _nomeMarca, int _Codigo)
        {
            NomeMarca = _nomeMarca;
            Codigo = _Codigo;
            DataCadastro = DateTime.Now;
        }


        public string Cadastrar(Marca marca)
        {
            ListaMarcas.Add(marca);
            return "Marca cadastrada com sucesso!";
        }

        public List<Marca> Listar()
        {
            return ListaMarcas;
        }

        public string Deletar(Marca marca, int index)
        {
            ListaMarcas.RemoveAt(index);
            return "Marca removida com sucesso!";
        }
        

       
    }
}