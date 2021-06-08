using System.Collections.Generic;
using Projeto_Produtos.Classes;

namespace Projeto_Produtos.Interfaces
{
    public interface IMarca
    {
        string Cadastrar(Marca marca);
        List<Marca> Listar();
        string Deletar(Marca marca);

    }
}