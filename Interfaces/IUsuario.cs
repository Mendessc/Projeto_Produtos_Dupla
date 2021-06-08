using Projeto_Produtos_Dupla.Classes;

namespace Projeto_Produtos_Dupla.Interfaces
{
    public interface IUsuario
    {
        string Cadastrar(Usuario usuario);
        string Deletar(Usuario usuario);
    }
}