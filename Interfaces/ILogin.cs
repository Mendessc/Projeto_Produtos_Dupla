namespace Projeto_Produtos_Dupla.Interfaces
{
    public interface ILogin
    {
        void Login()
        {

        }

        string Logar()
        {
            return "Você está logado";
        }

        string Deslogar()
        {
            return "Você foi Deslogado";
        }
    }
}