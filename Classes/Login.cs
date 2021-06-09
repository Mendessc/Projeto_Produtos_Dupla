using System;
using System.Collections.Generic;
using Projeto_Produtos.Classes;
using Projeto_Produtos_Dupla.Interfaces;

namespace Projeto_Produtos_Dupla.Classes
{
    public class Login : Usuario, ILogin
    {
        string Email;
        string Senha;
        bool LoginIncorreto = false;
        bool CadastroConcluido = false;
        bool RepeticaoMenu2 = true;
        string NomeMarca1;
        int c;

        Usuario usuario = new Usuario();
        Marca marcas = new Marca();
        Produto produto = new Produto();

        public string Deslogar()
        {
            return "Muito obrigado por utilizar o sistema! Você foi deslogado!";
        }


        public string Logar()
        {

            Console.WriteLine("Digite seu email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Digite sua senha: ");
            Senha = Console.ReadLine();



            return "Logado!";
        }

        public void FazerLogin()
        {
            do
            {
                Console.WriteLine($@"
Bem vindo! O que deseja fazer?
1 - Cadastrar Usuario
3 - Sair");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite seu email: ");
                        string _Email = Console.ReadLine();
                        Console.WriteLine("Digite sua senha: ");
                        string _Senha = Console.ReadLine();
                        Console.WriteLine("Digite seu nome: ");
                        string _Nome = Console.ReadLine();
                        Console.WriteLine("Digite seu código: ");
                        int _Codigo = int.Parse(Console.ReadLine());

                        Usuario u = new Usuario(_Codigo, _Nome, _Email, _Senha);

                        CadastroConcluido = true;

                        if (CadastroConcluido)
                        {
                            Console.WriteLine("Faça o login!");
                            do
                            {

                                Logar();

                                if (Email != usuario.RetornoEmail(u))
                                {
                                    Console.WriteLine("As credenciais estão incorretas!");
                                    LoginIncorreto = true;
                                }
                                else if (Senha != usuario.RetornoSenha(u))
                                {
                                    Console.WriteLine("As credenciais estão incorretas!");
                                    LoginIncorreto = true;
                                }
                                else
                                {
                                    Console.WriteLine("Zika do pantano");
                                    LoginIncorreto = false;
                                }
                            } while (LoginIncorreto);

                            do
                            {

                                Console.WriteLine($@"
Bem vindo ao sistema! O que deseja fazer?
1 - Cadastrar marca
2 - Listar Marcas
3 - Removar marcas
4 - Cadastrar Produto
5 - Listar Produto
6 - Remover Produto
0 - Deslogar e sair do sistema");
                                string opcaoMenu2 = Console.ReadLine();
                                switch (opcaoMenu2)
                                {
                                    case "1":
                                        Console.WriteLine("Qual o código da marca?");
                                        int CodMarca = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Qual o nome da sua marca?");
                                        NomeMarca1 = Console.ReadLine();

                                        Marca m1 = new Marca(NomeMarca1, CodMarca);
                                        Console.WriteLine(marcas.Cadastrar(m1));
                                        break;
                                    case "2":
                                        foreach (Marca marca in marcas.Listar())
                                        {
                                            
                                            marca.Listar();
                                            Console.WriteLine($@"

Nome:{marca.NomeMarca}
Código:{marca.Codigo}
Data do cadastro:{marca.DataCadastro}");
                                        }
                                        break;
                                    case "3":
                                        Console.WriteLine("Digite a posição da marca que você deseja excluir: ");
                                        int verificar = int.Parse(Console.ReadLine());
                                        verificar = verificar - 1;
                                        Console.WriteLine(marcas.Deletar(marcas, verificar));
                                        break;
                                    case "4":
                                        Console.WriteLine("Qual o código do produto?");
                                        int CodProduto = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Qual o nome do produto?");
                                        string NomeProduto = Console.ReadLine();
                                        Console.WriteLine("Qual o preço do produto?");
                                        float PrecoProduto = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Qual a marca do produto?");
                                        string CadastroMarca = Console.ReadLine();

                                        Produto p1 = new Produto(CodProduto, NomeProduto, PrecoProduto, CadastroMarca, u.Nome);
                                        Console.WriteLine(produto.Cadastrar(p1));
                                        break;
                                    case "5":
                                        foreach (Produto produto in produto.Listar())
                                        {
                                           
                                            produto.Listar();
                                            Console.WriteLine($@"

Nome:{produto.NomeProduto}
Código:{produto.Codigo}
Data do cadastro:{produto.DataCadastro}
Preço: {produto.Preco}
Marca: {produto.NomeMarca}
Cadastrado por: {produto.NomeUsuario}");
                                        }
                                        break;
                                    case "6":
                                        Console.WriteLine("Digite a posição da marca que você deseja excluir: ");
                                        int verificarP = int.Parse(Console.ReadLine());
                                        verificarP = verificarP - 1;
                                        Console.WriteLine(produto.Deletar(produto, verificarP));
                                        break;
                                    case "0":
                                        Console.WriteLine(Deslogar());
                                        RepeticaoMenu2 = false;
                                        CadastroConcluido = false;
                                        break;
                                    default:
                                        break;
                                }
                            } while (RepeticaoMenu2);

                        }
                        break;

                    case "3":
                        Console.WriteLine("Obrigado por utilizar o sistema!");
                        CadastroConcluido = false;
                        break;
                    default:
                        Console.WriteLine("A opção digitada está errada, tente novamente!");
                        break;
                }

            } while (CadastroConcluido);
        }
    }
}