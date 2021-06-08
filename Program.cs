using System;
using Projeto_Produtos.Classes;
using Projeto_Produtos.Interfaces; 

namespace Projeto_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Marca marca1 = new Marca();

            marca1.Cadastrar(marca1);

            marca1.Listar();
        }
    }
}
