using System;
using System.Collections.Generic;
using Projeto_Produtos_Dupla.Interfaces;

namespace Projeto_Produtos_Dupla.Classes
{
    public class Login : Usuario, ILogin
    {
        string Email;
        string Senha;
        bool LoginIncorreto = false;
        bool CadastroConcluido = false;

        Usuario usuario = new Usuario();

        public string Deslogar()
        {
            throw new System.NotImplementedException();
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