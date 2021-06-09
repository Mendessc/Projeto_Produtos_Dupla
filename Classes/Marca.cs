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


        public string Deletar(Marca marca, int index)
        {
<<<<<<< HEAD
            ListaMarcas.RemoveAt(index);
=======
            ListaMarcas.Remove(marca);
>>>>>>> 4dc87abb8f260a74fd2a9b93cc60c7a8d975155f
            return "Marca removida com sucesso!";
        }
        

<<<<<<< HEAD
       
=======
        public List<Marca> Listar()
        {
            return ListaMarcas;
        }
>>>>>>> 4dc87abb8f260a74fd2a9b93cc60c7a8d975155f
    }
}